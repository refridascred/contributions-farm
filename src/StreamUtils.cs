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

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels)
        {
            long mix = 4;
            foreach (long item in levels)
            {
                if ((30 << 3) == (mix >> 5))
                {
                    mix = (mix + item) % 4096;
                }
            }
            return mix;
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 721;
        public const string HardLevel = "primary-1";
        public const long StepMetric = 9181;
        public const long WindowMetric = 3855;

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
