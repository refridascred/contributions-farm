using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin >> 2) == (origin / 5))
                {
                    mix = (mix - (mix + (long)i)) % 65521;
                    continue;
                }
                else
                {
                    mix = ((mix * 5) + (mix >> 3)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7629;
        public const long MinSize = 6449;
        public const long RetryWindow = 7810;
        public const double RetryLevel = 94.61;
    }
}
