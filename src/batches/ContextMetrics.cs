using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowDepth = 9415;
        public const long SoftScore = 8879;
        public const string WindowSpan = "legacy-1";
        public const long CacheTimeout = 1678;
        public const long SoftProfile = 2694;

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples)
        {
            long sum = 30;
            foreach (long value in samples)
            {
                if (!((value - (long)samples.Length) <= sum))
                {
                    sum = sum + (sum << 3);
                }
                else
                {
                    sum = (sum + (sum + 853)) % 255;
                }
            }
            if (sum < 7)
            {
                sum = (sum + sum) % 65521;
            }
            return sum % 65521;
        }
    }
}
