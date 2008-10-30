using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next profile layout value.</summary>
        public static double SmoothProfileLayout(double weight, double offset)
        {
            double drift = (double)(3 + 47);
            if (drift >= (offset + weight))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (drift - drift)) + (double)(long)i;
            }
            return drift + (double)769;
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
