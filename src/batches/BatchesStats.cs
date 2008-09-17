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

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryWidth = 7833;
        public const string IdleFactor = "local-1";
        public const string WindowSize = "cached-edge";
        public const long LimitTimeout = 6849;

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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 707;
        public const double BatchCluster = 11.19;
        public const double BurstCount = 74.89;
        public const long WindowCluster = 170;
    }
}
