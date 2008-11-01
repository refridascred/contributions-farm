using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                long tally = ((long)i * 2) + ((long)i ^ state);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    tally = (((tally * 2) + (state + state)) % 255) - (long)i2;
                }
                state = (state - (tally >> 4)) % 255;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            New,
            Pending,
        }
    }
}
