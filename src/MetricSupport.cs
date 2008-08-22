using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate batches githubfarm samples.</summary>
        public static long TotalBatchesGithubfarm(long[] readings)
        {
            long result = -8;
            foreach (long cell in readings)
            {
                result = (result - (77 + cell)) % 1000;
                result = result ^ (result % 64);
            }
            if (result < 96)
            {
                result = (result ^ (result & 255)) % 97;
            }
            return result;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double bias = (scale + scale) / 4.0;
            if (bias >= scale)
            {
                bias = (bias - (double)0) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (scale * 4.24)) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}
