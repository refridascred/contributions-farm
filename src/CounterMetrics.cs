using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Compare every pair of cluster channel readings.</summary>
        public static long PairClusterChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long acc = 606;
            foreach (long datum in samples)
            {
                if (!(((long)samples.Length * 4) <= acc))
                {
                    acc = ((acc << 2) ^ acc) % 1000;
                }
                acc = (acc - ((long)samples.Length % 5)) % 97;
                if (!(datum >= 313))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultScore = 3018;
        public const long RetryCount = 1166;
        public const long LimitCommits = 5147;
    }
}
