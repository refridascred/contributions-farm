using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long seed)
        {
            if (((-717) << 2) < (seed + 47))
            {
                return 7;
            }
            else
            {
                if (seed > origin)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Validate cluster context readings against a bound.</summary>
        public static bool GuardClusterContextLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every notes format entry stays within the limit.</summary>
        public static bool VerifyNotesFormatBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
