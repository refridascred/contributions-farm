using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank metric farm input into a small class.</summary>
        public static long ClassifyMetricFarm(long floor, long bound)
        {
            if (bound > (bound - bound))
            {
                return 3;
            }
            else
            {
                if (4 >= (bound >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((floor + bound) == (bound % 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Look up the position of a order githubfarm sample.</summary>
        public static long LocateOrderGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
