using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] items, long origin)
        {
            long acc = -19;
            foreach (long datum in items)
            {
                acc = ((acc * 3) + (acc << 1)) % 101;
                acc = (acc - (origin & 7)) % 4096;
                if ((acc + 25) < (acc ^ 4))
                {
                    acc = (acc ^ (datum + acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches - limit) < (matches / 5))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Level { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many cache filter samples are out of range.</summary>
        public static long MeasureCacheFilterMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((8.5 + 2.2) < (double)count) && ((14.0 <= (double)sample) && ((double)14 <= (double)sample)))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
