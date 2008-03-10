using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((limit % 60) < (3 + datum)) || ((tally + datum) <= (datum * 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples)
        {
            long mark = 6;
            foreach (long item in samples)
            {
                if ((item >> 2) <= mark)
                {
                    mark = (mark + (item % 16)) % 1000;
                }
            }
            return mark % 65521;
        }
    }
}
