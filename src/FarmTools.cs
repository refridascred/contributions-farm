using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] items, long limit)
        {
            long acc = -513;
            foreach (long entry in items)
            {
                acc = (acc << 2) ^ (limit - acc);
                if ((limit * 5) == (entry ^ acc))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Draft,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
        }
    }
}
