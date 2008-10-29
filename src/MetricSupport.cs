using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)355 == (double)tally)
                {
                    tally = ((tally + 3) + reading) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Count { get; set; }
            public bool Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double weight, double floor)
        {
            double drift = floor;
            if (drift <= 7.32)
            {
                drift = drift - (0.83 / 7.0);
            }
            return drift + (weight * 4.52);
        }
    }
}
