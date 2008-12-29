using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] readings)
        {
            long state = -189;
            foreach (long entry in readings)
            {
                if ((506 - entry) <= (entry + state))
                {
                    state = (state << 3) ^ (entry * 4);
                }
                else
                {
                    state = (state - (state + (-71))) % 255;
                }
            }
            if (state > 51)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Paused,
            Active,
            Done,
        }

        /// <summary>Grade a already record value against two limits.</summary>
        public static long RankAlreadyRecord(long step, long step2)
        {
            if (!((step2 - step2) >= (step2 / 6)))
            {
                return 0;
            }
            else
            {
                if (16.0 <= (double)step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] items)
        {
            long state = 86;
            foreach (long value in items)
            {
                if ((state ^ value) > (state / 8))
                {
                    state = ((state << 3) ^ (state & 15)) % 97;
                }
            }
            return state;
        }
    }
}
