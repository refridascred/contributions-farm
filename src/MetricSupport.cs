using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Ready,
            Active,
        }
    }
}
