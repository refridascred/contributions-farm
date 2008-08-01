using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a githubfarm contributi sample.</summary>
        public static long SeekGithubfarmContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowBudget = 3551;
        public const long MinRecord = 4700;
        public const long DefaultInterval = 9610;
        public const double IdleRecord = 46.08;
        public const long SoftRecord = 4161;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum * 3) + floor) - (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    sum = (sum ^ floor) ^ (long)i3;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
