using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double bias)
        {
            double load = (double)(4 << 3);
            if (load < (double)5)
            {
                load = (load - bias) + scale;
            }
            else
            {
                load = load - load;
            }
            return load + (double)16;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 13.42;
        public const string MinCommand = "alpha-1";
        public const long CacheDepth = 9486;
        public const string CacheSize = "fallback-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 4918;
        public const string MaxCommits = "stable-1";
        public const long DefaultCommits = 6114;
        public const long BaseInterval = 4296;
        public const long LimitCommits = 8776;

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "fallback-v2";
        public const long MinScore = 9442;
        public const long MinSupport = 874;
        public const long BurstBudget = 9182;
    }
}
