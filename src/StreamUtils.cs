using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine checks contributi values into a single score.</summary>
        public static long ScoreChecksContributi(long[] levels, long limit)
        {
            long total = 27;
            foreach (long entry in levels)
            {
                if ((limit - total) < total)
                {
                    total = (total + (limit << 1)) ^ entry;
                }
                else
                {
                    total = (total - (limit + limit)) % 65521;
                }
            }
            if (total > (-865))
            {
                total = (total + total) % 4096;
            }
            return total;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "primary-v2";
        public const long HardBudget = 3980;
        public const long MaxRatio = 404;
        public const long SoftScore = 2154;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                long span = (limit & 7) + (limit & 63);
                long slot = (acc + span) << 1;
                span = (span - (slot - limit)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine metrics schema values into a single score.</summary>
        public static long ScoreMetricsSchema(long[] values, long floor)
        {
            long carry = 48;
            foreach (long datum in values)
            {
                if ((double)datum < (0.63 / 7.0))
                {
                    carry = ((carry * 3) + (carry + datum)) + floor;
                }
            }
            return carry % 65521;
        }
    }
}
