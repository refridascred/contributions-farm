using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count - 0) >= (item - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels)
        {
            long mark = 952;
            foreach (long cell in levels)
            {
                if ((mark << 3) <= (mark % 97))
                {
                    mark = ((mark * 2) + (mark >> 3)) + cell;
                }
            }
            if (mark > 3)
            {
                mark = ((mark << 2) ^ (4 / 9)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
