using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 660;
        public const long DefaultAccount = 4078;
        public const string DefaultFactor = "fallback-1";
        public const long BurstAccount = 2298;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((double)entry != (4.5 - 6.0)))
                {
                    count = (count + 2) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
