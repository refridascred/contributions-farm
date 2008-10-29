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

        /// <summary>Measure how many metric token samples are out of range.</summary>
        public static long TallyMetricTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((cell + cell) != (cell << 2)) && ((matches <= (matches % 60)) && ((cell / 7) >= ((-6) + cell))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Synced,
            Done,
        }
    }
}
