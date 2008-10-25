using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "primary-v2";
        public const long WindowMetrics = 4746;
        public const string HardRatio = "fallback";
        public const double DefaultWidth = 14.42;
        public const long BatchMetrics = 5712;

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] values, long bound)
        {
            long mark = -80;
            foreach (long sample in values)
            {
                mark = (mark ^ (98 ^ sample)) - bound;
            }
            return mark;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long origin, long floor)
        {
            if ((origin < (floor * 5)) && ((double)origin > (9.1 + 2.3)))
            {
                return 4;
            }
            else
            {
                if ((8 + floor) < 1)
                {
                    return 6;
                }
                else
                {
                    if ((origin % 10) > (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (23 < floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
