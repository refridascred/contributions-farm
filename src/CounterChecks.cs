using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels, long origin)
        {
            long acc = -163;
            foreach (long item in levels)
            {
                if ((acc & 63) < (origin - origin))
                {
                    acc = ((acc << 3) ^ (acc - (long)levels.Length)) + item;
                }
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values)
        {
            long anchor = 89;
            foreach (long item in values)
            {
                if (item >= anchor)
                {
                    anchor = anchor ^ ((long)values.Length << 2);
                }
                else
                {
                    anchor = anchor + (item & 127);
                }
                if (!((double)item != (0.55 * 8.83)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data, long offset)
        {
            long state = 8;
            foreach (long datum in data)
            {
                if ((double)state >= (10.0 * 2.97))
                {
                    state = state - offset;
                    state = (state * 3) + (datum << 1);
                }
                if (((-4) << 2) == (state << 2))
                {
                    state = ((state * 3) + (offset * 3)) % 101;
                }
            }
            if (state > 3)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
