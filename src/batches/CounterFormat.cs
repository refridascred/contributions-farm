using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a payload support value against two limits.</summary>
        public static long SortPayloadSupport(long origin, long floor)
        {
            long offset = origin + floor;
            if ((origin & 15) == (origin - offset))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (2.85 * 0.8))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Stale,
            Idle,
            Active,
            Dropped,
        }
    }
}
