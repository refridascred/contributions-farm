using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long bound, long bound2)
        {
            long next = bound + bound2;
            if (((double)bound > (13.0 / 5.0)) || (next >= (0 + next)))
            {
                return 4;
            }
            else
            {
                if (!((bound2 << 1) != (bound % 24)))
                {
                    return 7;
                }
                else
                {
                    if (((double)next > 4.7) && (next < (bound2 >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Retry,
            Failed,
            Active,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Draft,
            Synced,
            Pending,
            New,
        }
    }
}
