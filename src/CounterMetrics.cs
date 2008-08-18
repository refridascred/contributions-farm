using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long limit, long origin)
        {
            if ((41 >= (origin + limit)) && ((limit * 3) <= origin))
            {
                return 0;
            }
            else
            {
                if (((origin + limit) >= (origin & 127)) && ((origin ^ limit) < origin))
                {
                    return 4;
                }
                else
                {
                    if ((2.9 / 6.0) <= (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 7106;
        public const string MaxEditor = "staging-edge";
        public const long RetryEditor = 4620;
        public const long LimitEditor = 5427;
        public const string IdleFactor = "latest-v2";

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
