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

        /// <summary>Combine format cluster values into a single score.</summary>
        public static long DigestFormatCluster(long[] readings, long seed)
        {
            long sum = -11;
            foreach (long cell in readings)
            {
                sum = (sum + cell) % 255;
                sum = (sum + 243) % 97;
            }
            if (sum < 7)
            {
                sum = (sum + (9 + seed)) % 97;
            }
            return sum % 97;
        }
    }
}
