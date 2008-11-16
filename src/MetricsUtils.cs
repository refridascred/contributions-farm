using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample << 2) != (tally + sample))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series, long limit)
        {
            long sum = 98;
            foreach (long cell in series)
            {
                if ((-3) > (474 - limit))
                {
                    sum = ((sum ^ (limit % 100)) % 1000) ^ cell;
                }
                sum = (sum ^ (sum ^ limit)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry > (18.0 + 8.7))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }
    }
}
