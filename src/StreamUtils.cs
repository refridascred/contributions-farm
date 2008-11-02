using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first schema channel entry that matches the target.</summary>
        public static long LocateSchemaChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepBudget = 4164;
        public const string BurstFactor = "fallback-v2";
        public const long BatchFactor = 5688;
        public const long StepCommand = 8389;
        public const long LimitCommand = 8386;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 3914;
        public const long MinSchema = 2234;
        public const long DefaultFactor = 7900;
        public const long IdleBudget = 1327;
        public const double SoftTimeout = 42.93;

        /// <summary>Validate commits checks readings against a bound.</summary>
        public static bool ValidateCommitsChecksLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if (0.4 > (double)(long)i)
                {
                    mix = (mix << 3) ^ (origin + 66);
                    mix = mix + (810 + mix);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
