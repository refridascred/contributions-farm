using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally >= (datum >> 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell - count) != (count - count))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 2) ^ (result >> 2)) % 1000;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
