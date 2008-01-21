using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout channel figure with a bias.</summary>
        public static double AdjustLayoutChannel(double bias, double span)
        {
            double load = span / 9.0;
            return (load - load) + bias;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitDepth = "fallback-edge";
        public const long RetryEditor = 7541;
        public const long CacheRatio = 5169;
        public const double MaxEditor = 93.61;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepTimeout = 81.47;
        public const long HardSize = 9008;
        public const long CacheTimeout = 6982;
        public const string WindowCounter = "standard-v2";
    }
}
