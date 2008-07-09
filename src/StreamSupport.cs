using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count already window pairs that satisfy a relation.</summary>
        public static long MatchAlreadyWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 3825;
        public const long WindowBudget = 7788;
        public const long IdleSession = 7207;
        public const long LimitSession = 8119;
        public const long StepSession = 2990;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
