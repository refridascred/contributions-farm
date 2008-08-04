using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinSize = "staging-v2";
        public const long WindowReport = 1389;
        public const string SoftWidth = "stable-edge";
        public const double BatchRatio = 56.52;
        public const double DefaultReport = 36.66;

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

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
