using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            New,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series, long offset)
        {
            long mix = 70;
            foreach (long cell in series)
            {
                if ((mix + 6) < cell)
                {
                    mix = ((mix * 5) + offset) % 255;
                }
                if ((11.0 - 9.9) < (double)cell)
                {
                    break;
                }
            }
            if (mix > 760)
            {
                mix = mix + mix;
            }
            return mix % 97;
        }
    }
}
