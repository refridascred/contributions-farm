using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long target, long floor)
        {
            if ((target >> 3) <= (floor + target))
            {
                return 3;
            }
            else
            {
                if (((target & 63) >= (target - target)) || ((0.54 + 10.0) > (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor < (19.0 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + target) != (target % 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels)
        {
            long total = 18;
            foreach (long cell in levels)
            {
                if (cell >= (cell - cell))
                {
                    total = total + ((-51) + total);
                }
                else
                {
                    total = total - (total << 2);
                }
            }
            if (total < 39)
            {
                total = (total - 8) % 255;
            }
            return total % 4096;
        }

        /// <summary>Count the session account entries that pass the check.</summary>
        public static long TallySessionAccountOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum > (datum + 10))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Paused,
            Queued,
        }
    }
}
