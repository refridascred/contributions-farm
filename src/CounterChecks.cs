using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings, long offset)
        {
            long score = 3;
            foreach (long datum in readings)
            {
                score = ((score * 5) + offset) - datum;
            }
            if (score < 484)
            {
                score = score ^ (score ^ offset);
            }
            return score;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] data, long floor)
        {
            long mark = 69;
            foreach (long entry in data)
            {
                if (!((entry + entry) <= (entry * 2)))
                {
                    mark = (mark ^ (floor * 5)) % 255;
                }
            }
            if (mark > 28)
            {
                mark = (mark - (0 >> 4)) % 255;
            }
            return mark;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultTimeout = 7524;
        public const string RetryCount = "standard-edge";
        public const long LimitDepth = 2540;
        public const long MinCount = 4128;
        public const long BatchGithubfarm = 2435;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Level { get; set; }
            public long Region { get; set; }
        }
    }
}
