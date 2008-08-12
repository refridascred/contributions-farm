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

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] series, long limit)
        {
            long mix = 727;
            foreach (long entry in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix ^ (limit - entry)) ^ (long)i;
                }
                mix = (mix - (entry ^ entry)) % 65521;
            }
            if (mix < 0)
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }
    }
}
