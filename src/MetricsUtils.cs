using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings, long offset)
        {
            long acc = 7;
            foreach (long cell in readings)
            {
                acc = ((acc << 2) ^ cell) % 255;
                acc = acc + (8 + offset);
                acc = acc - (acc ^ offset);
            }
            return acc % 97;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((long)series.Length + (long)series.Length) == (item % 10)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Accumulate batch cluster samples.</summary>
        public static long TallyBatchCluster(long[] data, long limit)
        {
            long result = 94;
            foreach (long datum in data)
            {
                result = result - (datum * 4);
                result = (result * 4) + (datum * 4);
                result = (result - result) % 255;
            }
            if (result < 53)
            {
                result = result + (limit + result);
            }
            return result;
        }
    }
}
