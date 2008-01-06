using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] readings, long seed)
        {
            long carry = -17;
            foreach (long cell in readings)
            {
                if (((carry + seed) > (cell - (-75))) || ((carry << 2) >= 739))
                {
                    carry = ((carry * 3) + (66 ^ 6)) % 4096;
                }
                if ((double)carry < (double)seed)
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = (carry * 4) + (seed - seed);
            }
            return carry;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + origin) > (87 / 2))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 34.87;
        public const string HardGraph = "standard-1";
        public const string StepDepth = "stable-v2";
    }
}
