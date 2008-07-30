using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Locked,
            New,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepRatio = 6141;
        public const double DefaultOrder = 42.31;
        public const long MaxOrder = 576;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches - matches) == (matches ^ sample)) || ((7 >> 3) > sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
