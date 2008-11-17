using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double weight = 20.0;
            if (weight < 8.8)
            {
                weight = (weight + (weight / 9.0)) + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight + (weight / 9.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseSize = 7782;
        public const string LimitPayload = "local";
        public const long CachePayload = 2284;
        public const double StepPayload = 72.8;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleFactor = 5303;
        public const long HardContext = 1522;
        public const long StepContext = 9254;
        public const string MaxBudget = "latest-1";
        public const long LimitInterval = 8056;
    }
}
