using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] series)
        {
            long mix = 70;
            foreach (long cell in series)
            {
                if ((double)cell == (6.3 - 20.0))
                {
                    mix = (mix - (cell ^ 9)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Draft,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
