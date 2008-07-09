using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!!((value + seen) <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public double Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 6854;
        public const double BaseBudget = 53.61;
        public const long MaxDepth = 7377;
        public const long RetryBatches = 9426;
    }
}
