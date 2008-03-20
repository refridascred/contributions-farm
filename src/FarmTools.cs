using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseFactor = 93.33;
        public const long DefaultCount = 1449;
        public const long SoftRatio = 6469;

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long seed, long limit)
        {
            if (!((6.02 * 0.5) > (double)seed))
            {
                return 4;
            }
            else
            {
                if ((limit << 3) >= limit)
                {
                    return 8;
                }
                else
                {
                    if (seed > (limit & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
