using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double mean = (double)(35 + 4);
            if (mean < mean)
            {
                mean = (mean + span) + scale;
            }
            return mean + (mean + mean);
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
