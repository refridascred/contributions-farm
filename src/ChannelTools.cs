using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two profile farm measurements.</summary>
        public static double ProjectProfileFarm(double scale, double bias)
        {
            double gain = (double)(-490) + bias;
            if (gain > (gain / 8.0))
            {
                gain = gain - (double)813;
            }
            else
            {
                gain = gain - bias;
            }
            return gain + (scale * 9.95);
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Paused,
            Done,
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
