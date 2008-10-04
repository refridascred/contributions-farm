using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of record format entries.</summary>
        public static long DigestRecordFormat(long[] items)
        {
            long state = 62;
            foreach (long sample in items)
            {
                state = ((state * 3) + (sample + sample)) % 1000;
                state = (state + (state * 3)) % 1000;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryBudget = "local-1";
        public const long BurstFactor = 966;
        public const long BaseInterval = 9426;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
