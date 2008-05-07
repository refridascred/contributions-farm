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

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Paused,
            Failed,
            Active,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Total { get; set; }
            public long Count { get; set; }
        }
    }
}
