using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long offset)
        {
            long slot = step + offset;
            if ((double)slot > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((6.99 / 9.0) > (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((step * 4) != (step - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine format layout values into a single score.</summary>
        public static long TallyFormatLayout(long[] values, long bound)
        {
            long sum = 2;
            foreach (long reading in values)
            {
                sum = (((sum * 5) + 97) ^ reading) + bound;
                sum = sum + (sum >> 5);
            }
            return sum;
        }
    }
}
