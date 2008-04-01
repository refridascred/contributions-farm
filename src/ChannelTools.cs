using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (gain + bias)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long seed, long origin)
        {
            if (((origin - seed) > (seed - seed)) && (8.68 < (double)seed))
            {
                return 2;
            }
            else
            {
                if (((856 - seed) < (853 >> 4)) || ((17.0 + 4.0) != (double)seed))
                {
                    return 4;
                }
                else
                {
                    if (((origin / 8) <= origin) || ((origin & 7) > (origin + origin)))
                    {
                        return 0;
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
