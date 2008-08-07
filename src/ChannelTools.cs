using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two account command measurements.</summary>
        public static double SmoothAccountCommand(double gain, double span)
        {
            double scale = gain;
            if (scale <= gain)
            {
                scale = scale - (gain - span);
            }
            else
            {
                scale = scale - (double)282;
            }
            return scale + (gain + gain);
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double scale2 = (double)(75 - 57);
            if (scale2 < bias)
            {
                scale2 = scale2 + (scale - scale);
            }
            else
            {
                scale2 = scale2 + (double)3;
            }
            return scale2 + (scale2 + scale);
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
