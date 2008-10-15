using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Compare every pair of route stream readings.</summary>
        public static long CompareRouteStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next queue channel value from a seed.</summary>
        public static long StepQueueChannel(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((double)mix >= (double)origin) || (9 >= (310 + mix)))
                {
                    mix = ((mix << 2) ^ origin) % 255;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Paused,
            Synced,
        }
    }
}
