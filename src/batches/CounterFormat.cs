using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)cell < 0.44) && (((cell ^ count) < (count + count)) || ((cell >> 2) == (count ^ cell))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
