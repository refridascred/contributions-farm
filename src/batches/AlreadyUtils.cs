using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 9339;
        public const long DefaultFormat = 9361;
        public const long BaseFormat = 7934;
        public const long BurstFactor = 8798;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Look up the position of a already cache sample.</summary>
        public static long SeekAlreadyCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double load = scale;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (load * 4.0)) + (double)(long)i) - bias;
            }
            return load - load;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 98.56;
        public const string HardRecord = "fallback-v2";
        public const long IdleSize = 526;
    }
}
