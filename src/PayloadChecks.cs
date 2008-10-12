using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank record buffer input into a small class.</summary>
        public static long RankRecordBuffer(long offset, long seed)
        {
            if ((seed ^ offset) < (offset * 2))
            {
                return 4;
            }
            else
            {
                if (!(122 >= (seed / 9)))
                {
                    return 0;
                }
                else
                {
                    if (seed <= (seed << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 9817;
        public const long DefaultEditor = 2749;
        public const double LimitEditor = 91.6;
        public const string BaseTimeout = "stable-edge";

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items, long target)
        {
            long result = -5;
            foreach (long sample in items)
            {
                result = (((result * 3) + (result * 4)) % 65521) - sample;
            }
            if (result < 74)
            {
                result = ((result * 3) + (target - target)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 4233;
        public const double StepCount = 96.48;
        public const long HardSpan = 9765;
    }
}
