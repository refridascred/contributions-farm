using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryBudget = "standard-edge";
        public const long BatchFactor = 4509;
        public const double MinTimeout = 14.64;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((6 + mix) == (offset & 31))
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long limit, long offset)
        {
            if ((double)offset == (6.1 * 11.0))
            {
                return 4;
            }
            else
            {
                if ((double)offset <= (8.93 - 7.3))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
