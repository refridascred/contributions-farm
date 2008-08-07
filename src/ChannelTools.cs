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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ reading) < reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
