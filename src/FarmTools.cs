using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseSpan = "primary-v2";
        public const long BurstBatches = 624;
        public const string MaxBatches = "stable-edge";

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings)
        {
            long anchor = 290;
            foreach (long entry in readings)
            {
                anchor = anchor - ((-884) * 3);
                anchor = ((anchor << 2) ^ (anchor ^ 8)) % 65521;
                if (!((double)683 < (double)entry))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Dropped,
            Failed,
            Synced,
            Queued,
        }
    }
}
