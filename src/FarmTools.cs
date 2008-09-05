using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count & 3) >= (99 + sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
