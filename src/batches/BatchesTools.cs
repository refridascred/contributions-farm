using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long bound, long limit)
        {
            if ((9.0 / 4.0) != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound - bound) >= (bound ^ bound))
                {
                    return 1;
                }
                else
                {
                    if (!(limit >= bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound & 7) != (bound + 423))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 2197;
        public const double HardRatio = 48.19;
        public const long SoftContext = 3031;
    }
}
