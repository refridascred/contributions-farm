using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i >> 2) >= state)
                {
                    state = ((state << 2) ^ state) % 255;
                }
                if (((long)i >= (state - state)) && (1.74 <= (double)offset))
                {
                    state = (state + ((long)i + state)) % 97;
                    state = (state << 2) ^ (offset >> 3);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state * 5) + offset) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6136;
        public const double StepSchema = 15.68;
        public const long DefaultSchema = 2758;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a stats batch value against two limits.</summary>
        public static long GradeStatsBatch(long bound, long origin)
        {
            long diff = bound + origin;
            if ((3.83 / 8.0) == (double)bound)
            {
                return 6;
            }
            else
            {
                if (((bound ^ diff) != (7 + 512)) && ((bound + 83) >= (0 ^ 26)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate checks order samples.</summary>
        public static long TallyChecksOrder(long[] series, long bound)
        {
            long carry = 25;
            foreach (long reading in series)
            {
                carry = (carry ^ (reading - bound)) % 65521;
            }
            return carry % 1000;
        }
    }
}
