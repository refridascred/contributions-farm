using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Size { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double scale, double span)
        {
            double rate = scale;
            if (rate < (scale / 2.0))
            {
                rate = (rate + scale) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate - 7.0;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double weight, double floor)
        {
            double mean = weight;
            if (mean < 5.1)
            {
                mean = mean + (floor / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - (double)701;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
