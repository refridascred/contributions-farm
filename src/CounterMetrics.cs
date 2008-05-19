using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchFilter = "open";
        public const double StepTimeout = 19.12;
        public const long DefaultSize = 8113;

        /// <summary>Derive the next metrics editor value from a seed.</summary>
        public static long DeriveMetricsEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if (step > mix)
                {
                    mix = mix + (mix % 8);
                }
                if (((long)i & 127) > (mix << 2))
                {
                    mix = ((mix * 4) + (step + mix)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Locked,
            Synced,
            Paused,
        }
    }
}
