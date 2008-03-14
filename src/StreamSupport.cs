using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double bias, double offset)
        {
            double weight = (double)(2 - 66);
            if (weight >= bias)
            {
                weight = weight - (3.75 * 9.15);
            }
            else
            {
                weight = weight - (double)880;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long step, long step2)
        {
            long lane = step - step2;
            if (((step2 % 10) != (lane >> 1)) || ((step + step2) < lane))
            {
                return 6;
            }
            else
            {
                if ((step2 + lane) == (lane * 2))
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
