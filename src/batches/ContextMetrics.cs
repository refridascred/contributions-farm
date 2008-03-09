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

        /// <summary>Classify a batches context pair into a bucket.</summary>
        public static long SortBatchesContext(long offset, long step)
        {
            if ((9 * 3) <= (step + step))
            {
                return 2;
            }
            else
            {
                if (((71 / 7) >= (offset / 3)) || ((offset - step) >= (step - offset)))
                {
                    return 7;
                }
                else
                {
                    return 1;
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
