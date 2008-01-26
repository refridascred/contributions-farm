using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] data, long step)
        {
            long sum = -37;
            foreach (long value in data)
            {
                if ((sum + 29) < (step % 12))
                {
                    sum = (sum - (328 * 5)) ^ value;
                }
            }
            if (sum > 2)
            {
                sum = (sum - (step ^ sum)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Count order route pairs that satisfy a relation.</summary>
        public static long CompareOrderRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
