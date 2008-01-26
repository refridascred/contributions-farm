using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((62 << 1) == (entry & 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "latest-1";
        public const long HardScore = 6988;
        public const string CacheNotes = "cached-1";
        public const long IdleNotes = 1619;
        public const string BaseNotes = "fallback-v2";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit report tools readings against a rule.</summary>
        public static long CountReportToolsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((8.33 - 6.2) >= (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "open-v2";
        public const string DefaultTimeout = "strict-edge";
        public const long LimitQueue = 9336;
    }
}
