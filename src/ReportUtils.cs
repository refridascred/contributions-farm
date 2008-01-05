using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Active,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values, long origin)
        {
            long state = 447;
            foreach (long sample in values)
            {
                if (!((sample / 4) <= state))
                {
                    state = state - (state * 5);
                }
                if ((double)6 != (double)sample)
                {
                    break;
                }
            }
            if (state < 513)
            {
                state = (state - (origin + origin)) % 4096;
            }
            return state;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
