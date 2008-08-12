using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardWidth = 6445;
        public const double MaxGithubfarm = 64.4;
        public const string MinDepth = "legacy-v2";
        public const double IdleFactor = 40.96;

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double bias)
        {
            double load = bias;
            if (load >= (load + scale))
            {
                load = load - (double)16;
            }
            return load - (scale * 9.0);
        }
    }
}
