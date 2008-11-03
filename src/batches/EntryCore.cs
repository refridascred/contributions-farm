using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a contributi githubfarm counter forward.</summary>
        public static long SeriesContributiGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account contributi pair into a bucket.</summary>
        public static long SortAccountContributi(long seed, long origin)
        {
            if ((6.0 + 6.0) != (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed <= 4.0)
                {
                    return 6;
                }
                else
                {
                    if (origin > 184)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
