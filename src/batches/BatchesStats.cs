using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank layout checks input into a small class.</summary>
        public static long GradeLayoutChecks(long origin, long offset)
        {
            if ((offset * 5) < (offset + origin))
            {
                return 2;
            }
            else
            {
                if (!((double)1 >= (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "open";
        public const long BaseLayout = 1378;
        public const string StepInterval = "strict";
        public const string BurstLayout = "alpha-1";
        public const string BaseWidth = "local";

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
