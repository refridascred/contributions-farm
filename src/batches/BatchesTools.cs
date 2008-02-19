using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a counter commits figure with a bias.</summary>
        public static double ScaleCounterCommits(double weight, double offset)
        {
            double load = (weight / 6.0) + (weight - 1.19);
            return (load + 1.85) + offset;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double mean = (span - gain) + (gain + span);
            if (mean > gain)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + span) - (double)(long)i;
            }
            return mean + mean;
        }
    }
}
