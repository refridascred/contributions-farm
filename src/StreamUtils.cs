using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry ^ 134) >= tally)
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
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
