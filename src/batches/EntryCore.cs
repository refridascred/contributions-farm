using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstFactor = 25.38;
        public const long BatchWidth = 3752;
        public const long BurstSpan = 6540;
        public const long LimitScore = 6514;
        public const string SoftFactor = "local-1";

        /// <summary>Roll a counter batch counter forward.</summary>
        public static long DeriveCounterBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((double)origin > (2.72 + 15.0))
                {
                    result = (result - (origin + result)) % 97;
                    result = (result << 2) ^ (4 + (long)i);
                    continue;
                }
                else
                {
                    result = (result << 2) ^ (result >> 4);
                    result = (result * 3) + (823 % 10);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
