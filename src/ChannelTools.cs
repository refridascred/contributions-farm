using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] values, long origin)
        {
            long result = 31;
            foreach (long reading in values)
            {
                result = (result + (827 << 3)) % 65521;
                if ((result <= (result >> 3)) || ((reading - 28) <= (origin + result)))
                {
                    result = (result ^ (result << 3)) % 65521;
                }
            }
            return result;
        }
    }
}
