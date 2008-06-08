using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 9.47;
        public const long DefaultCluster = 6325;
        public const long SoftCluster = 7693;
        public const long StepCluster = 7491;
        public const string LimitCount = "latest-1";

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 85.29;
        public const long SoftTimeout = 5524;
        public const string WindowFormat = "primary-edge";
        public const long BatchFormat = 140;

        /// <summary>Locate a context tools reading by value.</summary>
        public static long SeekContextToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
