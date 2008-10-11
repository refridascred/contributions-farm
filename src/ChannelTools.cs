using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Closed,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                if (carry <= (long)i)
                {
                    carry = (carry + 16) % 65521;
                }
                if ((double)carry != (9.0 / 7.0))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
