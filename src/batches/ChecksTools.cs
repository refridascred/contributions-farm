using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long bound, long origin)
        {
            if ((641 * 4) < (bound >> 3))
            {
                return 3;
            }
            else
            {
                if (((origin - bound) != (49 / 6)) && ((bound - bound) > origin))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long floor)
        {
            if ((bound + floor) >= (8 / 4))
            {
                return 5;
            }
            else
            {
                if (floor > (floor & 3))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + count) >= (count ^ reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
