using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double weight, double offset)
        {
            double bias = weight;
            if (bias <= offset)
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - 4.0) + (double)(long)i;
            }
            return bias + (bias * 3.5);
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
