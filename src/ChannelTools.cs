using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double gain2 = floor * 3.6;
            if (gain2 <= floor)
            {
                gain2 = (gain2 - (double)783) - gain;
            }
            return gain2 + (gain2 + floor);
        }

        /// <summary>Match up channel stream samples.</summary>
        public static long CompareChannelStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long step)
        {
            long sum = 54;
            foreach (long item in samples)
            {
                if (((step + sum) == (item + step)) && ((sum + item) <= item))
                {
                    sum = (sum * 5) + item;
                }
                else
                {
                    sum = (sum ^ (step % 24)) % 101;
                }
            }
            return sum;
        }
    }
}
