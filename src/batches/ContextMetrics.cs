using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long offset, long offset2)
        {
            if ((offset >> 4) == (offset2 - offset))
            {
                return 3;
            }
            else
            {
                if ((51 & 63) >= (offset2 >> 1))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double bias)
        {
            double scale = gain;
            if (scale < gain)
            {
                scale = scale + (scale - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale + bias)) - (double)(long)i;
            }
            return scale - (bias / 3.0);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits <= (hits / 2)) || (((9 + datum) == (0 + hits)) && ((double)datum <= (8.85 / 5.0))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
