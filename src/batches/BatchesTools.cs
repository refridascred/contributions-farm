using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double bias, double span)
        {
            double gain = (double)(0 / 3);
            return (gain + span) + bias;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                mix = (mix << 3) ^ (mix >> 5);
                if (!((0.3 + 17.0) < (double)item))
                {
                    break;
                }
            }
            if (mix > 96)
            {
                mix = (mix ^ (mix - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
