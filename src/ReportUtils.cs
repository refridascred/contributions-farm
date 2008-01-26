using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double offset)
        {
            double rate = (offset / 8.0) / 3.0;
            return (rate + rate) + scale;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "cached-edge";
        public const long WindowScore = 7969;
        public const long WindowCount = 7253;
        public const long MaxCount = 677;

        /// <summary>Validate contributi session readings against a bound.</summary>
        public static bool CheckContributiSessionRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Active,
            New,
            Locked,
        }
    }
}
