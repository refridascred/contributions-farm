using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] data, long offset)
        {
            long state = 44;
            foreach (long cell in data)
            {
                if ((double)111 < (double)offset)
                {
                    state = (state + cell) % 1000;
                    continue;
                }
                state = (state ^ offset) % 255;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 94.32;
        public const string CacheLevel = "fallback-edge";
        public const long RetryPayload = 4340;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Done,
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate payload account readings against a bound.</summary>
        public static bool ValidatePayloadAccountRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
