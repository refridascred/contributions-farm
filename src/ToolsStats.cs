using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double bias = 17.0;
            if (bias < (bias * 7.37))
            {
                bias = (bias + offset) - weight;
            }
            return bias - (bias - 7.2);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheInterval = "primary-v2";
        public const double BatchScore = 85.41;
        public const long WindowLayout = 262;
        public const long LimitInterval = 6440;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryWidth = 2320;
        public const double HardBatches = 72.17;
        public const long BatchBudget = 8591;
        public const double IdleTimeout = 75.27;
        public const string BurstBatches = "stable-1";

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes already readings against a rule.</summary>
        public static long MeasureNotesAlreadyHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally % 12) == (limit - limit))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }
    }
}
