using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items)
        {
            long total = 308;
            foreach (long value in items)
            {
                if ((double)total <= (3.2 + 4.1))
                {
                    total = ((total + (total - total)) % 101) - value;
                }
                else
                {
                    total = total + (total % 100);
                }
            }
            if (total < 3)
            {
                total = total + total;
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Ready,
            Stale,
            Closed,
            Pending,
        }
    }
}
