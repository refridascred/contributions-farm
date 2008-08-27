using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a context graph figure with a bias.</summary>
        public static double ProjectContextGraph(double scale, double bias)
        {
            double load = (double)(654 - 359);
            if (load >= (1.64 * 17.0))
            {
                load = (load - scale) - bias;
            }
            return load - (scale - load);
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Ready,
            Stale,
        }
    }
}
