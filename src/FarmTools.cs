using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long bound)
        {
            long next = offset + bound;
            if ((offset >> 4) >= (offset + bound))
            {
                return 5;
            }
            else
            {
                if (bound >= (bound + offset))
                {
                    return 4;
                }
                else
                {
                    if ((next ^ offset) <= (bound >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound / 2) < (offset << 2)) || ((double)bound > (5.24 + 5.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double gain = scale;
            if (gain < (gain * 6.4))
            {
                gain = gain + 2.0;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (floor * 5.02)) + (double)(long)i;
            }
            return gain + 0.37;
        }
    }
}
