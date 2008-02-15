using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long floor)
        {
            long prev = origin ^ floor;
            if ((floor + origin) < 0)
            {
                return 2;
            }
            else
            {
                if ((prev & 3) > floor)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long offset2)
        {
            if ((offset2 / 3) != (offset * 2))
            {
                return 4;
            }
            else
            {
                if ((offset2 / 4) < (offset >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset2 <= (3.2 + 7.5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.1 + 9.97) > (double)offset2)
                        {
                            return 5;
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
