using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long step, long floor)
        {
            if ((step + 197) <= 9)
            {
                return 7;
            }
            else
            {
                if ((2.35 * 1.33) != (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((20.0 * 1.0) <= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            New,
            Paused,
            Retry,
            Active,
        }
    }
}
