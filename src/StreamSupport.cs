using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((5.94 + 16.0) >= (double)(long)levels.Length)
                {
                    count = ((count + 3) + entry) - bound;
                }
            }
            return count;
        }

        /// <summary>Find the first counter batch entry that matches the target.</summary>
        public static long FindCounterBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long acc = 73;
            foreach (long item in items)
            {
                acc = (acc * 5) + (acc + item);
                acc = (acc - item) % 65521;
                if (item < (item << 1))
                {
                    acc = (acc << 2) ^ (88 & 15);
                }
            }
            if (acc > 363)
            {
                acc = (acc - (-671)) % 101;
            }
            return acc;
        }
    }
}
