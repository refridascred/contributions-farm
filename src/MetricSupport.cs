using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double floor)
        {
            double drift = (double)511 + (gain - floor);
            if (drift < (double)65)
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - (gain + drift);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
