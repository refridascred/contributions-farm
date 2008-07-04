using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Dropped,
            Idle,
            Done,
            Locked,
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
