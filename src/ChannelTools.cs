using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally == (5.0 + 6.5))
                {
                    tally = ((tally + 2) + sample) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
