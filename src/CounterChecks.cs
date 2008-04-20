using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state << 2) ^ (offset * 5)) ^ (long)i2;
                }
                state = state ^ (offset >> 3);
                state = ((state << 3) ^ ((long)i - offset)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Locate a buffer contributi reading by value.</summary>
        public static long LocateBufferContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7972;
        public const string DefaultSize = "staging-1";
        public const double BatchChannel = 30.88;
        public const string BaseChannel = "alpha-1";

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
