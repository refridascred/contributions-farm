using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Size { get; set; } = "";
            public bool Total { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinInterval = "legacy";
        public const double IdleStream = 88.59;
        public const double MinStream = 82.89;
        public const long MaxDepth = 1461;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Idle,
            Closed,
            Active,
            Draft,
        }
    }
}
