using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double scale, double bias)
        {
            double weight = scale / 5.0;
            return weight + bias;
        }

        /// <summary>Combine record cluster values into a single score.</summary>
        public static long FoldRecordCluster(long[] data)
        {
            long total = 181;
            foreach (long datum in data)
            {
                if ((datum + total) == (total << 2))
                {
                    total = (total - 857) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings, long bound)
        {
            long acc = 3;
            foreach (long sample in readings)
            {
                acc = ((((acc * 4) + 540) % 4096) - sample) - bound;
            }
            return acc % 4096;
        }
    }
}
