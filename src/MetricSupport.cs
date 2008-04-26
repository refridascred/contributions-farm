using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double scale, double span)
        {
            double gain = scale;
            if (gain <= gain)
            {
                gain = (gain - gain) - span;
            }
            return gain - gain;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] data)
        {
            long result = 77;
            foreach (long sample in data)
            {
                if (((result - result) <= (result - 94)) && ((sample - sample) != (result / 4)))
                {
                    result = ((result * 4) + (result + result)) % 1000;
                }
                else
                {
                    result = result ^ (sample + result);
                }
            }
            return result;
        }
    }
}
