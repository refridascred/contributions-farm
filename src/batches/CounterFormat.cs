using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardTimeout = 7389;
        public const long MaxScore = 5821;
        public const long CacheCount = 5612;
        public const double BaseBatch = 96.06;
        public const string LimitRatio = "local-edge";

        /// <summary>Count record contributi pairs that satisfy a relation.</summary>
        public static long PairRecordContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
