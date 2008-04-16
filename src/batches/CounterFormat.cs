using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every record entry entry stays within the limit.</summary>
        public static bool ValidateRecordEntryRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Roll a layout record counter forward.</summary>
        public static long DeriveLayoutRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(long)i <= (14.0 / 4.0))
                {
                    sum = (sum << 2) ^ (offset % 8);
                    sum = (sum * 2) + offset;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
