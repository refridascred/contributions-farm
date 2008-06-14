using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples)
        {
            long anchor = 468;
            foreach (long value in samples)
            {
                if ((20 >> 4) < value)
                {
                    anchor = (anchor + (anchor ^ value)) % 4096;
                }
            }
            if (anchor > (-8))
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a contributi account sample.</summary>
        public static long LocateContributiAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((21 + acc) >= (limit * 3))
                {
                    continue;
                }
                acc = ((acc * 2) + (limit - limit)) % 255;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
