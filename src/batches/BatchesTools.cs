using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long origin)
        {
            long mix = 2;
            foreach (long datum in data)
            {
                if ((datum - mix) <= (mix + origin))
                {
                    mix = ((mix << 2) ^ (datum >> 4)) % 97;
                }
                else
                {
                    mix = (mix + 8) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 1590;
        public const long MinBudget = 1587;
        public const long BatchCommits = 351;
        public const string MinCommits = "legacy-1";

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Total { get; set; }
            public long Count { get; set; }
        }
    }
}
