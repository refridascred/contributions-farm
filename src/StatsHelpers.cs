using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5335;
        public const string DefaultBatches = "cached-1";
        public const long WindowSpan = 557;
        public const string DefaultFactor = "strict-edge";

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 3398;
        public const string CacheCount = "primary-v2";
        public const string StepPayload = "stable-v2";

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
