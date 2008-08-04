using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((value + tally) > (tally - value)) && (((-2) ^ tally) > tally)) && ((double)(long)values.Length >= (5.48 + 3.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxSize = "strict-edge";
        public const string IdleBuffer = "open";
        public const double DefaultBuffer = 36.72;

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardWidth = 5761;
        public const string DefaultMetrics = "local-edge";
        public const long BaseLevel = 7460;
        public const string BurstMetrics = "alpha-v2";

        /// <summary>Validate counter notes readings against a bound.</summary>
        public static bool CheckCounterNotesBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
