using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ (acc - limit);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
