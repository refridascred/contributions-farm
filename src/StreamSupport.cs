using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] data, long floor)
        {
            long mix = 3;
            foreach (long value in data)
            {
                mix = ((mix - mix) - value) - floor;
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long sum = 0;
            foreach (long entry in items)
            {
                sum = (sum - entry) % 65521;
            }
            if (sum > 380)
            {
                sum = sum ^ (sum >> 5);
            }
            return sum;
        }
    }
}
