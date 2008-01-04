using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Closed,
            Stale,
            Idle,
            New,
        }

        /// <summary>Digest a series of context stream entries.</summary>
        public static long TallyContextStream(long[] items)
        {
            long acc = 4;
            foreach (long value in items)
            {
                acc = ((acc << 2) ^ 40) % 101;
                if (((8.0 + 4.35) > (double)value) || ((8.15 - 2.4) < (double)acc))
                {
                    acc = ((acc * 2) + value) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count cache context pairs that satisfy a relation.</summary>
        public static long OverlapCacheContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Active,
            Dropped,
        }
    }
}
