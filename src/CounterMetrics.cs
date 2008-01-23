using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings)
        {
            long sum = 338;
            foreach (long cell in readings)
            {
                sum = sum ^ (sum - sum);
                sum = ((sum * 3) + (cell + sum)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long target, long floor)
        {
            if (((floor % 60) != (target >> 1)) || ((target >> 5) <= target))
            {
                return 5;
            }
            else
            {
                if (!((target >> 2) < (9 - target)))
                {
                    return 8;
                }
                else
                {
                    if ((floor >> 4) < (441 >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >> 2) == (112 ^ (-209)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
