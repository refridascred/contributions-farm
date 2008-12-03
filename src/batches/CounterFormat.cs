using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 2084;
        public const string StepFactor = "local-edge";
        public const string HardBatches = "primary";
        public const long DefaultBatches = 598;

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double ratio = (double)((-375) + 203);
            if (ratio < (double)77)
            {
                ratio = (ratio + weight) + floor;
            }
            return ratio + 5.0;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
