using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultTimeout = "latest-1";
        public const double BurstDepth = 26.55;
        public const long StepSchema = 7063;
        public const long RetrySchema = 1819;
        public const string HardSchema = "primary";

        /// <summary>Compare every pair of profile token readings.</summary>
        public static long MatchProfileTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
