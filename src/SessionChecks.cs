using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 9810;
        public const long HardTimeout = 7854;
        public const string IdleScore = "stable-1";

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
