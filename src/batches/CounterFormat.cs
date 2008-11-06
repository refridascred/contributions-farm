using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate checks already samples.</summary>
        public static long CombineChecksAlready(long[] readings)
        {
            long carry = 83;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (((carry << 2) ^ (cell - cell)) % 101) ^ (long)i;
                }
                if ((carry < ((long)readings.Length / 8)) && ((494 % 10) != (cell % 60)))
                {
                    carry = ((carry << 2) ^ (carry + cell)) % 101;
                }
                else
                {
                    carry = (carry * 3) + (83 - cell);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Failed,
            New,
            Active,
        }

        /// <summary>Compare every pair of notes tools readings.</summary>
        public static long OverlapNotesToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
