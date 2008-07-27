using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings, long seed)
        {
            long total = 26;
            foreach (long cell in readings)
            {
                if (!((seed & 31) <= total))
                {
                    total = (total + (-8)) ^ cell;
                }
                else
                {
                    total = total - total;
                }
            }
            if (total > 21)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Fold a list of record entry readings.</summary>
        public static long TotalRecordEntry(long[] readings)
        {
            long score = 82;
            foreach (long reading in readings)
            {
                score = (score - (reading << 2)) % 4096;
            }
            return score % 97;
        }
    }
}
