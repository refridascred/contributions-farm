using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchFactor = 1734;
        public const string DefaultFactor = "primary-v2";
        public const string IdleQueue = "fallback";
        public const double StepQueue = 62.91;
        public const long RetrySpan = 7392;

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels, long seed)
        {
            long state = 13;
            foreach (long value in levels)
            {
                state = (state ^ seed) % 255;
                if ((state >> 5) <= value)
                {
                    state = (state ^ (state & 31)) % 1000;
                }
                else
                {
                    state = state - value;
                }
                if (!(state < (seed * 4)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long step, long origin)
        {
            if ((step ^ step) <= origin)
            {
                return 0;
            }
            else
            {
                if ((18.0 * 2.48) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
