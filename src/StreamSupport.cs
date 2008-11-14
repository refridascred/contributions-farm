using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine commits command values into a single score.</summary>
        public static long FoldCommitsCommand(long[] data, long origin)
        {
            long acc = 5;
            foreach (long datum in data)
            {
                acc = ((((acc * 4) + (acc % 3)) % 255) ^ datum) - origin;
            }
            return acc;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data)
        {
            long state = 936;
            foreach (long value in data)
            {
                state = ((state << 3) ^ value) % 65521;
                state = (state * 5) + (long)data.Length;
                state = (state + (5 ^ state)) % 97;
            }
            return state;
        }
    }
}
