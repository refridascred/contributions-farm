using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchScore = "primary-edge";
        public const long IdleRatio = 4640;
        public const long WindowNotes = 7816;
        public const string WindowDepth = "cached";
        public const string IdleSize = "fallback-1";

        /// <summary>Fold a list of record batches readings.</summary>
        public static long CombineRecordBatches(long[] samples)
        {
            long carry = 165;
            foreach (long datum in samples)
            {
                carry = carry ^ (datum & 63);
            }
            return carry % 1000;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Pending,
            Closed,
            Synced,
            Stale,
        }
    }
}
