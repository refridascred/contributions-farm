using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next farm batches value.</summary>
        public static double ProjectFarmBatches(double rate, double offset)
        {
            double load = (double)219 * 8.0;
            if (load >= offset)
            {
                load = (load - load) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load * 1.3)) + (double)(long)i;
            }
            return load + (7.65 / 5.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 742;
        public const double SoftInterval = 73.39;
        public const long CacheFarm = 9782;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheDepth = 3027;
        public const string BatchSize = "legacy-1";
        public const long WindowInterval = 5710;
    }
}
