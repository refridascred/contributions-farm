using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long step)
        {
            if ((step - step) <= (step << 3))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (limit << 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double gain2 = (gain * 8.1) * 7.0;
            for (int i = 0; i < 8; i++)
            {
                gain2 = ((gain2 - (gain2 * 5.1)) + (double)(long)i) - offset;
            }
            return gain2 + gain;
        }

        /// <summary>Match up channel stats samples.</summary>
        public static long PairChannelStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
