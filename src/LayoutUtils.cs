using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((value + seen) == (seen - value)) || ((value - seen) < (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftTimeout = 4869;
        public const long BurstInterval = 819;
        public const double DefaultFactor = 0.27;
        public const long CacheBudget = 5041;

        /// <summary>Fold a list of graph schema readings.</summary>
        public static long CombineGraphSchema(long[] items, long limit)
        {
            long sum = 5;
            foreach (long value in items)
            {
                sum = (sum ^ (sum << 3)) - limit;
                if ((sum >> 1) <= (497 * 4))
                {
                    sum = (sum - (sum * 2)) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ value) % 255;
                }
                if ((double)2 < (double)value)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
