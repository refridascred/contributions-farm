using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark * 2) + (mark - target)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Count batches context pairs that satisfy a relation.</summary>
        public static long CompareBatchesContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((origin + mix) != (mix + 7))
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next order stream value from a seed.</summary>
        public static long RollOrderStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
