using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double scale = (double)(8 + 702);
            return ((scale + (double)97) + gain) + offset;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSpan = 5201;
        public const double CacheCount = 47.63;
        public const double HardNotes = 32.94;
        public const long DefaultBudget = 7488;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinInterval = 86.04;
        public const string CacheGraph = "primary";
        public const double BaseGraph = 0.24;
        public const long StepRatio = 1589;
        public const long MaxGraph = 7154;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }
    }
}
