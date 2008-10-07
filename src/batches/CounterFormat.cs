using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batch schema samples are out of range.</summary>
        public static long MeasureBatchSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits << 1) != (entry & 1)) && (599 >= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] series)
        {
            long carry = 8;
            foreach (long datum in series)
            {
                if ((datum * 2) > (datum - (-483)))
                {
                    carry = (carry * 4) + (long)series.Length;
                }
            }
            return carry;
        }
    }
}
