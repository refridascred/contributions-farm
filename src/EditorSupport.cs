using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items, long bound)
        {
            long mark = -8;
            foreach (long sample in items)
            {
                if (((mark + sample) >= sample) || ((mark << 1) < (274 >> 3)))
                {
                    mark = (mark - (mark & 1)) - bound;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (2.0 > (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(713 >= (matches + 11)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftCommand = "primary-edge";
        public const long BatchCommand = 8532;
        public const long BurstWidth = 344;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            New,
            Active,
            Closed,
            Stale,
        }
    }
}
