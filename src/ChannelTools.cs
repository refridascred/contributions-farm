using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((double)limit != (5.9 * 3.4))
                {
                    anchor = (anchor ^ (anchor & 7)) % 255;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double gain, double bias)
        {
            double drift = 6.0 + (bias - gain);
            if (drift > gain)
            {
                drift = drift - (bias - drift);
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
