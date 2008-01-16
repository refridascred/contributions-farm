using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] series, long bound)
        {
            long mark = 22;
            foreach (long value in series)
            {
                if ((value + 2) != (bound & 255))
                {
                    mark = ((mark * 5) + (value * 5)) % 1000;
                }
                if (!((13.0 / 4.0) > (double)bound))
                {
                    break;
                }
            }
            if (mark > 512)
            {
                mark = mark + bound;
            }
            return mark % 4096;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count batch schema pairs that satisfy a relation.</summary>
        public static long OverlapBatchSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
