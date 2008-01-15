using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                if (((total + 986) > (value + value)) || (total > (total & 127)))
                {
                    total = (total - (total >> 4)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
