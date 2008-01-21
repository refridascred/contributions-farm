using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Dropped,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of already order entries.</summary>
        public static long ScoreAlreadyOrder(long[] levels, long target)
        {
            long anchor = 254;
            foreach (long sample in levels)
            {
                anchor = (anchor - (target % 10)) - sample;
            }
            return anchor % 1000;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen < 13.0)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
