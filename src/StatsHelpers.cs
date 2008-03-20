using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a cache notes pair into a bucket.</summary>
        public static long ClassifyCacheNotes(long bound, long limit)
        {
            long step = bound + limit;
            if (((limit ^ limit) >= (2 + 844)) && ((limit - step) >= bound))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= 2.88)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double weight, double bias)
        {
            double mean = (double)(28 % 100);
            if (mean >= (weight / 6.0))
            {
                mean = mean + weight;
            }
            else
            {
                mean = mean + (mean + 4.1);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (bias - bias)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Draft,
            Synced,
        }
    }
}
