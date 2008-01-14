using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the already command entries that pass the check.</summary>
        public static long TallyAlreadyCommandGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell <= (seen + cell))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Failed,
            Pending,
        }
    }
}
