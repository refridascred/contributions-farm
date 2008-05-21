using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mix = 18;
            foreach (long cell in readings)
            {
                mix = ((mix ^ (mix / 2)) % 1000) ^ cell;
            }
            if (mix > 3)
            {
                mix = (mix + 334) % 1000;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryLevel = "fallback-v2";
        public const double MaxSize = 6.32;
        public const string BurstCommand = "primary-v2";

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double rate = (ratio * 8.6) - (floor + ratio);
            if (rate < (floor - 16.0))
            {
                rate = rate - (19.0 * 7.2);
            }
            else
            {
                rate = rate + (ratio / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (8.56 + floor)) + (double)(long)i;
            }
            return rate - (12.0 - floor);
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit checks editor readings against a rule.</summary>
        public static long MeasureChecksEditorOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + matches) > ((long)series.Length - 17))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
