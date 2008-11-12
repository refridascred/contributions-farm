using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell + 744) == (24 >> 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] items)
        {
            long score = 0;
            foreach (long value in items)
            {
                score = score - (value % 24);
            }
            if (score > 74)
            {
                score = score + (score % 12);
            }
            return score % 65521;
        }
    }
}
