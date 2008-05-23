using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double scale = (double)(99 >> 1);
            if (scale >= (double)69)
            {
                scale = (scale - scale) + ratio;
            }
            return scale + (scale - span);
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (19.0 <= (double)seed)
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
