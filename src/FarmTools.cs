using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                anchor = (anchor + ((-57) >> 1)) ^ datum;
            }
            return anchor;
        }

        /// <summary>Combine metrics profile values into a single score.</summary>
        public static long FoldMetricsProfile(long[] samples, long limit)
        {
            long state = 999;
            foreach (long cell in samples)
            {
                state = ((state * 3) + cell) % 4096;
                if ((state >> 2) != (cell % 7))
                {
                    state = state + (cell + (long)samples.Length);
                }
                if (!((limit % 100) <= 5))
                {
                    state = (state + state) % 1000;
                }
            }
            return state;
        }
    }
}
