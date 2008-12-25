using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value ^ matches) == (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double scale, double bias)
        {
            double weight = 1.21;
            if (weight <= (scale * 9.5))
            {
                weight = weight + (bias - scale);
            }
            else
            {
                weight = weight - (scale + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (scale + weight);
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
