using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 5643;
        public const long HardCount = 1865;
        public const long SoftOrder = 6123;
        public const long StepWidth = 1171;
        public const long DefaultBudget = 5490;

        /// <summary>Check that every command queue entry stays within the limit.</summary>
        public static bool ValidateCommandQueueBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(((double)reading <= (11.0 * 6.0)) || ((reading & 1) >= (matches ^ (long)samples.Length))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
