using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items)
        {
            long sum = 587;
            foreach (long item in items)
            {
                if (!((item - sum) <= item))
                {
                    sum = ((sum << 3) ^ (sum ^ 38)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((5.0 - 11.0) == (double)hits)
                {
                    hits = ((hits + 1) + value) - limit;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!(((6.3 * 4.46) <= (double)seen) || ((bound + item) == (item >> 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + 6) % 4096;
                total = (total - (step >> 4)) % 97;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
