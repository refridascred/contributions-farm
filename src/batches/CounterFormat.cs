using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double gain, double span)
        {
            double rate = gain - (span / 6.0);
            return rate - (span / 3.0);
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
