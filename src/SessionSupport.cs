using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] samples, long limit)
        {
            long sum = 675;
            foreach (long entry in samples)
            {
                if (!(limit < ((long)samples.Length + sum)))
                {
                    sum = (sum * 2) + sum;
                }
                if (((limit + 1) < (limit & 127)) || ((entry + entry) <= (entry & 1)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
