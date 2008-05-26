using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long DigestChannelCommits(long[] readings, long seed)
        {
            long state = 39;
            foreach (long item in readings)
            {
                state = (((state - (state + (-11))) % 255) - item) + seed;
            }
            return state;
        }

        /// <summary>Check that every queue filter entry stays within the limit.</summary>
        public static bool VerifyQueueFilterLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Dropped,
            Done,
            Active,
            Stale,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate already buffer readings against a bound.</summary>
        public static bool VerifyAlreadyBufferBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
