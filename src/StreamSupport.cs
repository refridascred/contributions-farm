using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double load = gain * 0.79;
            return (load - (gain / 6.0)) + floor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 50.69;
        public const long CacheAlready = 6500;
        public const long WindowAlready = 3971;
        public const long SoftSpan = 3224;
        public const string StepAlready = "primary";
    }
}
