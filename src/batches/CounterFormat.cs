using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values, long target)
        {
            long state = 11;
            foreach (long datum in values)
            {
                state = ((state ^ ((long)values.Length + datum)) % 101) - target;
            }
            return state;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
