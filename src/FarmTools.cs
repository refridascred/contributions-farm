using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] values, long step)
        {
            long state = 7;
            foreach (long reading in values)
            {
                if (reading < (step - 25))
                {
                    continue;
                }
                else
                {
                    state = (state - (state & 3)) % 97;
                }
                if (((double)state <= (0.96 * 9.7)) || ((step & 63) > (step / 8)))
                {
                    continue;
                }
                state = state + (step + reading);
            }
            return state % 1000;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Queued,
            Done,
            Closed,
            New,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] readings)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                if (!((5.81 / 5.0) == (double)item))
                {
                    mark = (mark - 5) % 97;
                }
            }
            if (mark < 4)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }
    }
}
