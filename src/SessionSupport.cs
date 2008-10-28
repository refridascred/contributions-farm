using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cache stream readings against a bound.</summary>
        public static bool ValidateCacheStreamRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double drift = offset;
            if (drift >= (double)5)
            {
                drift = drift + (double)964;
            }
            else
            {
                drift = drift - (offset * 3.55);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (1.82 + weight);
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long offset, long target)
        {
            long edge = offset ^ target;
            if ((edge & 31) > (target - 64))
            {
                return 8;
            }
            else
            {
                if (!((235 % 64) < edge))
                {
                    return 2;
                }
                else
                {
                    if ((offset - edge) == (offset % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)edge < (16.0 + 8.65))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
