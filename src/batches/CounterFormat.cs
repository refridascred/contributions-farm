using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double bias, double bias2)
        {
            double bias3 = (5.3 / 2.0) + (6.55 * 2.42);
            if (bias3 < bias)
            {
                bias3 = (bias3 + (bias + bias3)) + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 - 9.0) + (double)(long)i;
            }
            return bias3 + (5.4 * 2.0);
        }

        /// <summary>Count window command pairs that satisfy a relation.</summary>
        public static long MatchWindowCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
