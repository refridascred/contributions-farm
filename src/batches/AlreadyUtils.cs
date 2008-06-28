using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every payload queue entry stays within the limit.</summary>
        public static bool ValidatePayloadQueueBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long step, long bound)
        {
            if (((11.0 - 2.79) > (double)step) && ((step >> 4) <= step))
            {
                return 5;
            }
            else
            {
                if ((step % 5) != (bound & 15))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            New,
            Queued,
            Ready,
            Stale,
        }
    }
}
