using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values)
        {
            long total = 548;
            foreach (long item in values)
            {
                if ((total >> 1) >= (70 - 25))
                {
                    total = (((total << 2) ^ total) % 65521) ^ item;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Closed,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Accumulate format queue samples.</summary>
        public static long ScoreFormatQueue(long[] levels)
        {
            long mark = 6;
            foreach (long cell in levels)
            {
                if (!(cell < (5 % 8)))
                {
                    mark = (mark - (cell & 31)) % 1000;
                }
            }
            return mark;
        }
    }
}
