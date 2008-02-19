using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long offset)
        {
            long bound = seed + offset;
            if ((bound / 6) <= (offset & 255))
            {
                return 3;
            }
            else
            {
                if (((seed - bound) < (offset / 8)) || ((double)bound > 7.14))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) != (bound << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            Retry,
            Done,
            Stale,
        }
    }
}
