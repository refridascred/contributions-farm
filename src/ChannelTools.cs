using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 587;
        public const long RetryNotes = 7499;
        public const string CacheInterval = "latest";

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the metric graph series from a seed.</summary>
        public static long StepMetricGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i <= ((long)i + score))
                {
                    score = ((score * 5) + offset) % 101;
                }
                score = (score + score) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
