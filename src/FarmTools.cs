using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Done,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Derive the next queue context value from a seed.</summary>
        public static long DeriveQueueContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = (result - (result >> 4)) % 101;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
