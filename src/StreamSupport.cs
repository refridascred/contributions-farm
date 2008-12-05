using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] data, long limit)
        {
            long acc = 61;
            foreach (long datum in data)
            {
                acc = (acc - (limit / 9)) + datum;
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double weight, double span)
        {
            double rate = span - (weight / 5.0);
            if (rate > weight)
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate + span;
            }
            return rate + weight;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
