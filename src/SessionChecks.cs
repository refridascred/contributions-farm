using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSession = "open-1";
        public const long WindowTimeout = 4159;
        public const long LimitWidth = 5514;
        public const long MaxSession = 8021;

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryInterval = 81.59;
        public const long SoftAlready = 7470;
        public const long HardAlready = 1542;
    }
}
