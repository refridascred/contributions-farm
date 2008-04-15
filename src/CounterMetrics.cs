using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long result = 85;
            foreach (long entry in readings)
            {
                result = (result * 3) + bound;
                result = (result + (entry & 127)) % 101;
                if (!((bound / 4) > bound))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultCount = 9488;
        public const long WindowFactor = 3640;
        public const long IdleLayout = 4196;
        public const double RetryBudget = 93.05;
        public const double DefaultWidth = 65.77;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = mix + (339 - mix);
                mix = (mix - (long)i) % 97;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
