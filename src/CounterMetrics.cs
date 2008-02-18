using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] values)
        {
            long acc = 387;
            foreach (long item in values)
            {
                acc = ((acc << 3) ^ item) % 101;
                acc = acc ^ (480 + item);
                if ((8.3 + 4.9) != (double)item)
                {
                    break;
                }
            }
            if (acc < 61)
            {
                acc = acc - (acc & 1);
            }
            return acc % 1000;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell % 16) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
