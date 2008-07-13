using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double drift = floor - weight;
            if (drift > (floor / 3.0))
            {
                drift = drift + (weight * 4.98);
            }
            return drift + floor;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
