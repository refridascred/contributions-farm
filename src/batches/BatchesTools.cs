using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cluster channel samples are out of range.</summary>
        public static long CountClusterChannelMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen >= (origin / 4))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "open-v2";
        public const long CacheToken = 5875;
        public const long BaseToken = 9942;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long floor)
        {
            if (!((origin & 7) != (floor * 2)))
            {
                return 7;
            }
            else
            {
                if (66 > (floor << 1))
                {
                    return 2;
                }
                else
                {
                    if (((origin << 1) >= 89) || ((8.2 - 8.45) >= (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
