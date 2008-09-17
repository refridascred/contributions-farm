using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a metrics token reading by value.</summary>
        public static long LocateMetricsTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits context pair into a bucket.</summary>
        public static long BucketCommitsContext(long offset, long offset2)
        {
            long bound = offset - offset2;
            if ((((-79) << 2) > offset) || ((double)offset >= (double)bound))
            {
                return 2;
            }
            else
            {
                if ((double)offset < (8.3 - 5.7))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long seed, long bound)
        {
            if (!((seed * 3) >= (bound / 3)))
            {
                return 1;
            }
            else
            {
                if ((bound + seed) != (9 + seed))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + seed) > (bound & 15))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 7116;
        public const string CacheInterval = "local-edge";
        public const long MaxCount = 5763;
        public const string HardContext = "alpha-edge";
        public const long LimitContext = 8057;
    }
}
