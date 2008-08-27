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

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 1225;
        public const string WindowReport = "stable-1";
        public const string BaseInterval = "strict-v2";

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
