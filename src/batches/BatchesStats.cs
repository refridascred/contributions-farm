using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double bias, double floor)
        {
            double load = (double)3 - bias;
            if (load >= (double)0)
            {
                load = (load - 19.0) - floor;
            }
            else
            {
                load = load + load;
            }
            return load + load;
        }

        /// <summary>Validate farm filter readings against a bound.</summary>
        public static bool CheckFarmFilterBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 89.53;
        public const string DefaultWidth = "local";
        public const long HardLevel = 3131;
        public const string DefaultTimeout = "latest-edge";
        public const double BaseRecord = 5.73;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
