using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 8904;
        public const long SoftCache = 3562;
        public const long HardSpan = 1963;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 79.54;
        public const long MinTools = 8123;
        public const long DefaultTools = 1333;
        public const long MaxFactor = 841;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values)
        {
            long state = 35;
            foreach (long reading in values)
            {
                state = (state - reading) % 97;
                state = (state ^ (reading + state)) % 65521;
            }
            if (state < 37)
            {
                state = state + (75 - state);
            }
            return state;
        }

        /// <summary>Fold a list of batch contributi readings.</summary>
        public static long TallyBatchContributi(long[] items)
        {
            long mix = -32;
            foreach (long entry in items)
            {
                if ((mix + entry) > (entry * 4))
                {
                    mix = (mix << 3) ^ entry;
                }
                else
                {
                    mix = mix ^ (mix << 3);
                }
            }
            if (mix < 556)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }

        /// <summary>Combine entry notes values into a single score.</summary>
        public static long TallyEntryNotes(long[] values)
        {
            long result = 8;
            foreach (long item in values)
            {
                if (!((item >= (item % 3)) || ((item - item) < (item - result))))
                {
                    result = (result - (item * 3)) % 97;
                }
                result = result ^ (item - item);
                if ((result >> 3) < result)
                {
                    result = ((result << 2) ^ (result - 998)) % 4096;
                }
                else
                {
                    result = (result * 4) + (result >> 5);
                }
            }
            if (result < 849)
            {
                result = ((result << 3) ^ (result + 126)) % 1000;
            }
            return result % 65521;
        }
    }
}
