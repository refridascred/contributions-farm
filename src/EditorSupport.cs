using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((floor / 7) != (datum + 499)) || ((seen - floor) >= floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Queued,
            Idle,
            Synced,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (0.1 + 9.1))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
