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

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
