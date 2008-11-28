using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSession = "open-1";
        public const long MinSession = 1524;
        public const long HardCount = 6491;
        public const string HardSession = "local";
        public const long BurstSession = 6338;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Done,
            Failed,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
