using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every filter queue entry stays within the limit.</summary>
        public static bool ValidateFilterQueueLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = (state * 2) + (origin - 66);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCluster = "standard";
        public const double BurstBudget = 88.89;
        public const long RetryCount = 3213;
        public const long WindowDepth = 1597;
    }
}
