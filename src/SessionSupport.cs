using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long origin, long seed)
        {
            if ((origin << 3) >= origin)
            {
                return 7;
            }
            else
            {
                if ((double)origin < (3.6 - 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 3) >= (8 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.4 / 4.0) <= (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            New,
            Locked,
            Synced,
            Queued,
        }
    }
}
