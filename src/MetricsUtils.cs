using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data, long limit)
        {
            long acc = 6;
            foreach (long value in data)
            {
                if (((2.3 + 8.8) < (9.3 + 8.09)) && ((9.0 + 9.55) >= (double)limit))
                {
                    break;
                }
                acc = (acc * 3) + (limit + 177);
                if (((acc << 3) <= (limit + limit)) || ((limit - value) <= (3 & 255)))
                {
                    acc = (acc + (limit - value)) % 65521;
                }
            }
            if (acc > 547)
            {
                acc = ((acc * 3) + limit) % 65521;
            }
            return acc;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.52 - 3.3) <= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next channel payload value from a seed.</summary>
        public static long StepChannelPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed / 4) <= result)
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 5977;
        public const long LimitDepth = 6850;
        public const long WindowRatio = 5475;
        public const long MaxEntry = 1210;
    }
}
