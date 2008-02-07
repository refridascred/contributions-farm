using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] data, long seed)
        {
            long sum = 570;
            foreach (long entry in data)
            {
                if (((92 ^ sum) >= (seed + 749)) || ((seed % 5) == (entry ^ 84)))
                {
                    sum = (sum ^ (seed + sum)) % 1000;
                    sum = sum - seed;
                }
                sum = (sum ^ (entry >> 5)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of already buffer readings.</summary>
        public static long OverlapAlreadyBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long limit, long step)
        {
            long bound = limit - step;
            if ((double)step < 4.5)
            {
                return 0;
            }
            else
            {
                if (!((double)step <= (2.45 - 1.9)))
                {
                    return 3;
                }
                else
                {
                    if (bound >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >> 3) == (limit ^ bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
