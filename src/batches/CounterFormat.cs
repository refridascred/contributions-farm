using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long seed)
        {
            if ((seed % 60) == (step - seed))
            {
                return 7;
            }
            else
            {
                if ((step + step) >= seed)
                {
                    return 6;
                }
                else
                {
                    if ((step * 5) == (923 & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step % 12) >= (seed / 9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 2) ^ (seed - seed)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
