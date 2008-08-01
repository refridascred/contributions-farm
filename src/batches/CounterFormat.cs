using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double ratio = (double)213 / 2.0;
            if (ratio < (ratio + gain))
            {
                ratio = (ratio + 2.17) + span;
            }
            return ratio + 5.03;
        }

        /// <summary>Look up the position of a stream window sample.</summary>
        public static long FindStreamWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
