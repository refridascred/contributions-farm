using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double drift = (double)((-8) - 840);
            if (drift <= span)
            {
                drift = (drift + 4.0) + scale;
            }
            return drift - 16.0;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 9522;
        public const long DefaultCommits = 953;
        public const string WindowLevel = "open";

        /// <summary>Project the next record graph value.</summary>
        public static double ProjectRecordGraph(double bias, double bias2)
        {
            double load = bias2 * 15.0;
            if (load >= load)
            {
                load = (load + (double)1) - bias;
            }
            else
            {
                load = load - (20.0 - 8.9);
            }
            return load - load;
        }
    }
}
