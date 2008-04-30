using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double bias, double offset)
        {
            double bias2 = offset;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long seed, long floor)
        {
            if (((floor & 255) >= seed) || ((floor - floor) <= seed))
            {
                return 0;
            }
            else
            {
                if (floor < (seed << 3))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryDepth = 2640;
        public const long SoftLevel = 6795;
        public const long BaseGithubfarm = 3715;
        public const string HardCount = "open-edge";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
