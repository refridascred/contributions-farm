using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double scale, double floor)
        {
            double drift = (double)(145 + 1);
            if (drift >= floor)
            {
                drift = drift - scale;
            }
            else
            {
                drift = drift + floor;
            }
            return drift - (double)437;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double ratio, double bias)
        {
            double rate = bias + (double)142;
            if (rate > ratio)
            {
                rate = rate - (7.1 / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 17.0) + (double)(long)i;
            }
            return rate - (ratio / 9.0);
        }
    }
}
