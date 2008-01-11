using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Stale,
            New,
            Pending,
        }

        /// <summary>Project the next notes context value.</summary>
        public static double SmoothNotesContext(double bias, double span)
        {
            double drift = (double)(8 / 9);
            if (drift <= 5.0)
            {
                drift = ((drift + (4.08 / 5.0)) - bias) - span;
            }
            else
            {
                drift = drift - 2.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (double)(-74)) - (double)(long)i;
            }
            return drift - (double)24;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long target, long step)
        {
            if ((step - step) < (step + target))
            {
                return 1;
            }
            else
            {
                if ((target * 3) == (3 ^ target))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
