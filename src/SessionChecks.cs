using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepScore = 97.22;
        public const double MaxDepth = 0.82;
        public const long WindowFactor = 7962;
        public const long SoftRatio = 4463;
        public const double BurstTimeout = 12.34;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchTimeout = 6690;
        public const double LimitBudget = 76.06;
        public const double WindowBuffer = 14.3;
        public const double MinBuffer = 19.28;
        public const long BaseBuffer = 185;
    }
}
