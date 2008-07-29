using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every context cache entry stays within the limit.</summary>
        public static bool GuardContextCacheBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] levels, long target)
        {
            long state = 75;
            foreach (long entry in levels)
            {
                state = (state - 0) % 101;
                if (((state + target) >= (state ^ target)) || ((960 + entry) >= state))
                {
                    state = state + (target & 31);
                }
            }
            if (state < 484)
            {
                state = (state - (state - target)) % 1000;
            }
            return state;
        }
    }
}
