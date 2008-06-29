using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 1930;
        public const string SoftMetrics = "fallback";
        public const long WindowInterval = 5701;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data, long target)
        {
            long total = -18;
            foreach (long entry in data)
            {
                total = (((total * 4) + (target - 464)) % 65521) - entry;
            }
            return total;
        }

        /// <summary>Audit route stream readings against a rule.</summary>
        public static long MeasureRouteStreamMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((step & 15) != (25 & 7))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowBudget = 96.98;
        public const long SoftBudget = 1197;
        public const long MaxRecord = 6519;

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series)
        {
            long carry = 9;
            foreach (long reading in series)
            {
                if (carry >= (carry ^ reading))
                {
                    carry = (carry + (264 + 644)) % 1000;
                }
            }
            if (carry > 700)
            {
                carry = carry + (carry - carry);
            }
            return carry % 4096;
        }
    }
}
