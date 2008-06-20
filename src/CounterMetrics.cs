using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] data, long target)
        {
            long mix = 0;
            foreach (long entry in data)
            {
                mix = ((mix << 3) ^ mix) - entry;
                mix = (mix - (target + mix)) % 1000;
            }
            if (mix < 58)
            {
                mix = (mix + target) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
