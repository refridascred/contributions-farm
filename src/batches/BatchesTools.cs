using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] samples, long floor)
        {
            long mix = 5;
            foreach (long item in samples)
            {
                if (floor > (mix ^ item))
                {
                    mix = (mix - (item - item)) % 65521;
                }
                else
                {
                    mix = mix + (item >> 4);
                }
            }
            if (mix < 825)
            {
                mix = ((mix * 4) + (floor / 2)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels, long bound)
        {
            long total = 833;
            foreach (long sample in levels)
            {
                total = ((total + (707 / 2)) ^ sample) + bound;
            }
            if (total > 42)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
