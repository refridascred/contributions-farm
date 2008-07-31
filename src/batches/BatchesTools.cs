using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Paused,
            Failed,
            Locked,
            Active,
            New,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
