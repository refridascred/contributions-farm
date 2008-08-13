using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Done,
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                long delta = (sum % 8) - (step % 7);
                if ((double)(long)i == (double)3)
                {
                    sum = ((sum << 3) ^ delta) % 101;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "fallback";
        public const long DefaultBatches = 4656;
        public const long MaxDepth = 2510;
    }
}
