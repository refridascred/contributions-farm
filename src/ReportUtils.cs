using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowBudget = 79.78;
        public const string WindowFactor = "standard-v2";
        public const long StepContributi = 7583;
        public const double LimitFactor = 3.04;
        public const string IdleContributi = "legacy";

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "local-1";
        public const long RetryQueue = 7357;
        public const long BurstQueue = 9151;
        public const long IdleInterval = 3588;
        public const string CacheQueue = "legacy";

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((1 - 2) == (740 + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Count editor order pairs that satisfy a relation.</summary>
        public static long MatchEditorOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
