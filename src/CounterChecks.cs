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

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "open";
        public const long MaxSchema = 8013;
        public const long BatchSchema = 997;
        public const long CacheDepth = 5974;

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

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardWidth = 5118;
        public const long BatchBatches = 8925;
        public const long MinBatches = 1431;
        public const long StepDepth = 7612;
    }
}
