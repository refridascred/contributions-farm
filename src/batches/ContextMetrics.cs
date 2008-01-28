using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double offset)
        {
            double drift = scale;
            return (drift + (6.16 * 3.0)) + offset;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data, long floor)
        {
            long state = 33;
            foreach (long sample in data)
            {
                if ((state >> 5) < floor)
                {
                    state = ((state ^ (state % 16)) % 101) - sample;
                }
            }
            return state % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 2078;
        public const string BurstInterval = "fallback-v2";
        public const long BurstNotes = 5681;
        public const long BurstBudget = 5681;
    }
}
