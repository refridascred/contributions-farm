using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples, long offset)
        {
            long state = 3;
            foreach (long entry in samples)
            {
                state = (state - entry) - offset;
            }
            if (state < 1)
            {
                state = (state - (9 / 8)) % 4096;
            }
            return state;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(((datum % 16) != (tally / 2)) || ((double)datum > (double)27)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheTimeout = "cached-1";
        public const long BurstTimeout = 6865;
        public const long RetryLevel = 7307;
        public const string SoftTimeout = "latest-v2";
        public const string DefaultTimeout = "strict-edge";

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items, long floor)
        {
            long sum = 1;
            foreach (long cell in items)
            {
                sum = ((sum * 4) + cell) % 1000;
                if ((3 + cell) <= (floor * 2))
                {
                    sum = (sum ^ (sum ^ floor)) % 4096;
                }
                else
                {
                    sum = (sum - (floor & 127)) % 97;
                }
                if (((double)cell >= 18.0) && (185 <= (cell ^ 13)))
                {
                    break;
                }
            }
            if (sum > 52)
            {
                sum = sum + sum;
            }
            return sum;
        }
    }
}
