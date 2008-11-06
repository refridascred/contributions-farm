using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double gain, double offset)
        {
            double load = gain;
            return (load - gain) + offset;
        }
    }
}
