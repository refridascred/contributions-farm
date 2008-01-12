using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstSpan = 2751;
        public const long IdleBatch = 6103;
        public const string BurstBatch = "fallback-v2";

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 2) ^ ((long)i ^ bound)) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = sum + ((long)i2 + sum);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell < 75)
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
