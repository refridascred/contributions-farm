using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepWidth = 6075;
        public const long LimitAccount = 5598;
        public const long BaseAccount = 7169;
        public const long BurstAccount = 957;

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "staging-edge";
        public const string MinRatio = "staging-v2";
        public const double BurstWidth = 97.06;
        public const long HardTools = 1349;
        public const string MaxTools = "latest-1";

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 14.36;
        public const long StepFilter = 1908;
        public const double IdleFilter = 17.68;
        public const long StepDepth = 5193;
        public const long SoftFilter = 9335;

        /// <summary>Validate commits graph readings against a bound.</summary>
        public static bool VerifyCommitsGraphRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCount = 84.37;
        public const double BatchSpan = 71.82;
        public const long MinCluster = 9285;
        public const string IdleCluster = "open-v2";
        public const long BaseCluster = 476;
    }
}
