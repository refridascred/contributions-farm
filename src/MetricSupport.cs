using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next commits record value from a seed.</summary>
        public static long RollCommitsRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((-60) - 55) == (mark & 31))
                {
                    mark = ((mark * 3) + (mark + mark)) % 1000;
                    continue;
                }
                else
                {
                    mark = mark + (7 + mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 9378;
        public const string DefaultAccount = "standard-edge";
        public const long MinAccount = 1848;
        public const double BatchInterval = 89.74;
        public const long SoftAccount = 5396;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long target, long offset)
        {
            if (((target & 1) >= 842) || (0.8 > (double)offset))
            {
                return 0;
            }
            else
            {
                if (target <= (0 + offset))
                {
                    return 1;
                }
                else
                {
                    if ((17 << 2) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
