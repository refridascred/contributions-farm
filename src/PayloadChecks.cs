using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every format buffer entry stays within the limit.</summary>
        public static bool ValidateFormatBufferBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] series, long bound)
        {
            long total = 25;
            foreach (long reading in series)
            {
                total = (((total << 2) ^ bound) % 65521) - reading;
            }
            if (total < 34)
            {
                total = (total ^ (total + bound)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Project the next graph tools value.</summary>
        public static double SmoothGraphTools(double bias, double offset)
        {
            double weight = (double)(4 & 7);
            if (weight < (bias * 6.0))
            {
                weight = (weight - (double)4) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight - 4.8;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long limit, long limit2)
        {
            if (((double)limit > (double)5) || ((double)limit2 >= (3.2 - 1.9)))
            {
                return 1;
            }
            else
            {
                if (((limit2 * 3) > (limit2 ^ (-50))) || ((282 >> 1) >= limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 5) <= (0 / 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit - 117) < limit) && ((limit >> 4) < (limit2 - limit2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double scale = bias - (double)340;
            if (scale >= (scale - scale))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - 8.1) + (double)(long)i;
            }
            return scale - (weight + 6.8);
        }
    }
}
