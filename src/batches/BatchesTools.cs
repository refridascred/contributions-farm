using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value < (value - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
