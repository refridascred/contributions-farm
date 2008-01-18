using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "primary";
        public const double CacheCommits = 78.49;
        public const long CacheWidth = 4827;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 4543;
        public const long IdleRatio = 3645;
        public const long BurstRatio = 7109;
        public const long MaxBudget = 8055;
        public const long BurstCount = 8492;
    }
}
