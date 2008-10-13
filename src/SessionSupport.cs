using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first checks cluster entry that matches the target.</summary>
        public static long SeekChecksClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples, long bound)
        {
            long mark = 2;
            foreach (long item in samples)
            {
                if (1.0 < (double)item)
                {
                    mark = mark ^ (bound - bound);
                }
            }
            if (mark > 91)
            {
                mark = (mark - (83 + mark)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
