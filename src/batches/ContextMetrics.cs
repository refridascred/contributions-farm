using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long bound, long floor)
        {
            long step = bound - floor;
            if ((step % 64) > bound)
            {
                return 8;
            }
            else
            {
                if ((step >= (bound ^ step)) || ((bound >> 3) != (step << 1)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchFactor = 4377;
        public const long MinDepth = 3756;
        public const long MaxNotes = 1758;
        public const long BatchNotes = 8624;

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long result = 0;
            foreach (long item in values)
            {
                if ((result - 52) > (result - result))
                {
                    result = result - (91 + 44);
                    break;
                }
                if ((double)item <= 8.2)
                {
                    result = ((result * 4) + (item % 60)) % 1000;
                }
            }
            if (result > (-4))
            {
                result = ((result << 3) ^ (result >> 3)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
