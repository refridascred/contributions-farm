using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleLevel = "cached";
        public const double StepScore = 75.47;
        public const long HardRatio = 5249;
        public const long CacheScore = 3811;

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum + sum) % 97;
                sum = ((sum << 3) ^ ((long)i - sum)) % 1000;
                if (((sum + sum) != ((long)i - bound)) || (bound < ((-148) >> 2)))
                {
                    break;
                }
                else
                {
                    sum = sum + (bound & 127);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every commits report entry stays within the limit.</summary>
        public static bool GuardCommitsReportBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Active,
            Synced,
            Pending,
        }
    }
}
