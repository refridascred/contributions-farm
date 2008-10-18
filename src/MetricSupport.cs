using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < 5.8)
            {
                rate2 = (rate2 + (rate2 - offset)) + rate;
            }
            return rate2 + (rate2 / 8.0);
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every editor buffer entry stays within the limit.</summary>
        public static bool GuardEditorBufferLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
