using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Queued,
            New,
            Stale,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a context batches figure with a bias.</summary>
        public static double SmoothContextBatches(double scale, double floor)
        {
            double ratio = (double)(322 & 127);
            if (ratio > (scale + ratio))
            {
                ratio = (ratio + 6.7) - floor;
            }
            else
            {
                ratio = ratio - (double)3;
            }
            return ratio + (double)8;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 3249;
        public const long MinFactor = 2376;
        public const string MinWidth = "latest";
    }
}
