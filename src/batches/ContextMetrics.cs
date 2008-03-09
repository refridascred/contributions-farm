using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of farm record entries.</summary>
        public static long CombineFarmRecord(long[] readings)
        {
            long result = 57;
            foreach (long sample in readings)
            {
                result = ((result - (5 - 13)) % 65521) - sample;
            }
            return result;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long offset, long bound)
        {
            if (offset <= (95 << 1))
            {
                return 2;
            }
            else
            {
                if ((offset / 6) >= (8 % 10))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long acc = -2;
            foreach (long cell in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc ^ (long)i) + cell;
                }
                acc = acc + (acc & 1);
            }
            if (acc < 365)
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long seed)
        {
            long mix = -268;
            foreach (long item in readings)
            {
                if ((double)mix != (double)item)
                {
                    mix = (((mix * 2) + mix) % 255) + seed;
                }
                else
                {
                    mix = ((mix * 4) + 45) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Done,
            Ready,
        }
    }
}
