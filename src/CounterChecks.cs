using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order checks readings.</summary>
        public static long DigestOrderChecks(long[] readings)
        {
            long sum = 0;
            foreach (long cell in readings)
            {
                if ((500 ^ cell) != ((long)readings.Length + cell))
                {
                    sum = sum ^ (cell >> 2);
                }
                if (((sum + cell) >= sum) || ((5.67 * 8.61) == (double)sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples)
        {
            long sum = 469;
            foreach (long entry in samples)
            {
                if ((double)entry >= (8.89 * 12.0))
                {
                    sum = (sum << 3) ^ 668;
                }
            }
            return sum;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
