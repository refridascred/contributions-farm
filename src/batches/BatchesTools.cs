using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Dropped,
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] values, long floor)
        {
            long mix = 57;
            foreach (long sample in values)
            {
                if (((double)mix >= (6.57 + 5.2)) && ((double)42 > (double)floor))
                {
                    mix = (mix - 292) % 65521;
                }
                if (((979 / 8) != (3 + floor)) && ((floor - sample) > ((long)values.Length % 24)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
        }
    }
}
