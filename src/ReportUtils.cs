using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = rate + (span - 3.41);
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain - span)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double span)
        {
            double weight = span;
            if (weight < (weight / 5.0))
            {
                weight = (weight - weight) - scale;
            }
            return weight - span;
        }
    }
}
