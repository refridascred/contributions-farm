using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Draft,
            Stale,
            Retry,
            New,
        }

        /// <summary>Check that every format batches entry stays within the limit.</summary>
        public static bool CheckFormatBatchesLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8966;
        public const string BurstRoute = "fallback-v2";
        public const long StepSpan = 746;
        public const long HardRoute = 2938;
        public const long CacheDepth = 8878;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((origin - 928) < (seen << 2))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
