using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
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

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
