using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double gain, double offset)
        {
            double drift = (double)54 + (gain + gain);
            return (drift + gain) + offset;
        }

        /// <summary>Check that every command context entry stays within the limit.</summary>
        public static bool ValidateCommandContextLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many report schema samples are out of range.</summary>
        public static long TallyReportSchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((9.72 * 18.0) == (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
