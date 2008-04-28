using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double scale, double span)
        {
            double weight = (double)(0 ^ 92);
            if (weight < (scale / 7.0))
            {
                weight = weight + (double)344;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + span;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Dropped,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
