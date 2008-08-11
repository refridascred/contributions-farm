using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] series, long step)
        {
            long result = -2;
            foreach (long reading in series)
            {
                if ((result <= (step + result)) || (step >= (step + step)))
                {
                    result = ((result - (result + step)) % 101) + reading;
                }
            }
            if (result > 723)
            {
                result = ((result * 2) + (step / 8)) % 4096;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitSize = "open";
        public const long RetryTimeout = 975;
        public const string LimitInterval = "alpha-1";
        public const long LimitDepth = 872;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
