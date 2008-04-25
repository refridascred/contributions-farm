using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up contributi report samples.</summary>
        public static long CompareContributiReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Locked,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Validate window report readings against a bound.</summary>
        public static bool ValidateWindowReportLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next command schema value from a seed.</summary>
        public static long IterateCommandSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                if ((state + (-7)) <= target)
                {
                    state = ((state << 2) ^ (state << 1)) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
