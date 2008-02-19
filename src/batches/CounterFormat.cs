using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings, long limit)
        {
            long result = 2;
            foreach (long datum in readings)
            {
                if (((result & 7) <= 5) && ((datum % 5) <= result))
                {
                    result = result ^ (result << 1);
                }
                if (((8.3 + 17.0) >= (double)(long)readings.Length) || ((double)limit <= (4.77 * 6.0)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Find the first batch stream entry that matches the target.</summary>
        public static long FindBatchStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
