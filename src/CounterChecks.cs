using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Paused,
            Dropped,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch command measurements.</summary>
        public static double ProjectBatchCommand(double ratio, double bias)
        {
            double weight = bias / 4.0;
            if (weight > ratio)
            {
                weight = weight - (double)948;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (ratio * 2.9)) - (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((origin ^ 45) < (origin - (long)i)))
                {
                    state = state + origin;
                    state = ((state << 2) ^ (state * 2)) % 255;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinWidth = 1525;
        public const long BurstSize = 2334;
        public const string BaseWidth = "alpha";
        public const long HardCount = 3445;
    }
}
