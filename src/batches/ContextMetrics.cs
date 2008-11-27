using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data)
        {
            long score = 62;
            foreach (long cell in data)
            {
                if ((4.7 - 7.49) <= (double)(long)data.Length)
                {
                    score = ((score * 5) + (score & 127)) % 97;
                }
                else
                {
                    score = (score ^ (score - cell)) % 101;
                }
            }
            if (score < 514)
            {
                score = (score - (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i & 7) < mix)
                {
                    continue;
                }
                else
                {
                    mix = ((mix * 2) + (limit % 7)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of stream farm readings.</summary>
        public static long CombineStreamFarm(long[] levels)
        {
            long sum = 2;
            foreach (long sample in levels)
            {
                if ((double)sum > (20.0 * 0.3))
                {
                    sum = (sum - sample) % 4096;
                }
            }
            if (sum < (-452))
            {
                sum = ((sum * 2) + (sum ^ sum)) % 101;
            }
            return sum;
        }

        /// <summary>Classify a cluster command pair into a bucket.</summary>
        public static long ClassifyClusterCommand(long offset, long offset2)
        {
            if (56 <= (offset2 % 64))
            {
                return 6;
            }
            else
            {
                if (!((3 % 64) != (offset2 + offset)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Failed,
            Done,
            Active,
        }
    }
}
