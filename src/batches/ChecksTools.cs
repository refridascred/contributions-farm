using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Stale,
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long step, long seed)
        {
            if ((2 < step) && ((double)step >= (5.92 - 1.4)))
            {
                return 4;
            }
            else
            {
                if ((step - seed) < seed)
                {
                    return 8;
                }
                else
                {
                    if ((768 ^ seed) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
