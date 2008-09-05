using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a notes batches sample.</summary>
        public static long SeekNotesBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 52.08;
        public const double HardScore = 49.13;
        public const long BatchRecord = 7432;
        public const long CacheRecord = 430;
        public const double StepRecord = 88.77;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
