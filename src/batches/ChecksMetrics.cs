using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((bound + 0) == (bound % 60))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Draft,
            Failed,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Draft,
            Idle,
        }
    }
}
