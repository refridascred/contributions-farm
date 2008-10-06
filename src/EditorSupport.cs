using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the editor profile entries that pass the check.</summary>
        public static long MeasureEditorProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((6 - 267) <= (entry / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the stream batches entries that pass the check.</summary>
        public static long TallyStreamBatchesOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((offset / 2) >= 0)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Mode { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitInterval = 34.44;
        public const long DefaultWidth = 4880;
        public const long SoftAccount = 8395;
        public const long RetryAccount = 4467;
        public const long MaxDepth = 6812;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Ready,
            Synced,
        }
    }
}
