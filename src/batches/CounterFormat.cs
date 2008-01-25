using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 88.32;
        public const long LimitWidth = 7621;
        public const long RetryContext = 6150;

        /// <summary>Count checks metrics pairs that satisfy a relation.</summary>
        public static long PairChecksMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long floor, long step)
        {
            long next = floor + step;
            if ((0 << 1) > (next - floor))
            {
                return 2;
            }
            else
            {
                if (step > (step ^ 6))
                {
                    return 7;
                }
                else
                {
                    if ((step + step) > 0)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
