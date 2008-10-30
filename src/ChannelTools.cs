using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long mix = 2;
            foreach (long reading in samples)
            {
                mix = (mix ^ (reading ^ 142)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double ratio, double offset)
        {
            double rate = 12.0 * 0.22;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - (4.25 + 20.0)) - (double)(long)i) + offset;
            }
            return rate - ratio;
        }
    }
}
