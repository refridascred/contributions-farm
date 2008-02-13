using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepFactor = 5286;
        public const long BurstCounter = 9176;
        public const long CacheCount = 4235;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Roll a checks schema counter forward.</summary>
        public static long RollChecksSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                if (((double)state != (double)target) && (state >= (state - target)))
                {
                    state = ((state * 2) + target) % 1000;
                    state = (state ^ (state + target)) % 1000;
                }
                else
                {
                    state = (state + (988 - 99)) % 101;
                }
                state = (state * 5) + (target - (long)i);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a record batches counter forward.</summary>
        public static long DeriveRecordBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((double)floor <= (5.75 + 1.0))
                {
                    anchor = ((anchor * 3) + (floor - floor)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
