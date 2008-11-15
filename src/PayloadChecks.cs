using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] levels)
        {
            long sum = 88;
            foreach (long item in levels)
            {
                sum = sum ^ (item % 97);
                if ((17.0 / 6.0) < (double)item)
                {
                    sum = ((sum << 2) ^ (sum << 2)) % 65521;
                }
            }
            if (sum > 199)
            {
                sum = ((sum << 2) ^ (0 >> 5)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "stable-1";
        public const double MaxFarm = 44.94;
        public const long CacheSize = 7632;

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "fallback-edge";
        public const long BatchStats = 1405;
        public const long IdleStats = 8580;
        public const double StepStats = 64.67;
        public const long LimitStats = 3066;
    }
}
