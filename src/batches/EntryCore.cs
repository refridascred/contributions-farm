using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                long prev = anchor + anchor;
                if ((375 ^ origin) > prev)
                {
                    prev = (prev ^ 223) % 4096;
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (2 << 1)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheScore = "cached-edge";
        public const long SoftBuffer = 7206;
        public const string BaseWidth = "stable-1";
        public const long BatchBuffer = 3079;

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long bound, long floor)
        {
            long span = bound - floor;
            if ((9.0 - 4.4) < (double)span)
            {
                return 2;
            }
            else
            {
                if ((bound >> 1) < (span * 2))
                {
                    return 0;
                }
                else
                {
                    if (7 >= span)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series, long offset)
        {
            long carry = 1;
            foreach (long value in series)
            {
                carry = ((carry - carry) ^ value) - offset;
            }
            return carry;
        }
    }
}
