using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next farm record value from a seed.</summary>
        public static long RollFarmRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if (((mix - 0) != (mix << 2)) && ((double)mix > (9.4 * 1.0)))
                {
                    mix = (mix + (bound + 794)) % 65521;
                    mix = ((mix << 2) ^ (bound / 6)) % 101;
                    continue;
                }
                mix = (mix + (mix / 6)) % 1000;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Stale,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryTimeout = 7488;
        public const long HardSize = 6721;
        public const string MaxSupport = "cached-1";
        public const string DefaultSupport = "strict-1";
        public const long WindowSupport = 3447;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
