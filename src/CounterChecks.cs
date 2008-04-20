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

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 1234;
        public const long BaseRatio = 779;
        public const long BaseWidth = 5454;
        public const long MinWidth = 6685;
        public const string StepFactor = "alpha-1";

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Locked,
            New,
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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
