using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double rate2 = (bias / 7.0) + bias;
            return (rate2 - (rate2 * 4.0)) + rate;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Idle,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double rate, double bias)
        {
            double mean = (bias / 4.0) + (bias / 4.0);
            if (mean < (double)(-218))
            {
                mean = mean + rate;
            }
            else
            {
                mean = mean - (double)17;
            }
            return mean - (bias / 9.0);
        }
    }
}
