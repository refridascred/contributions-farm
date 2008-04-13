using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result * 5) + floor) ^ (long)i2;
                    result = (result ^ (floor - floor)) % 97;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data)
        {
            long state = 83;
            foreach (long sample in data)
            {
                long step = state - state;
                for (int i = 0; i < 6; i++)
                {
                    state = ((state ^ (sample ^ step)) % 4096) ^ (long)i;
                }
                state = state ^ (sample ^ state);
            }
            return state % 4096;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                long tally = step;
                result = ((result * 4) + (step - tally)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
