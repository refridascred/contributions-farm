using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 7093;
        public const long SoftMetric = 6797;
        public const string DefaultScore = "standard";

        /// <summary>Iterate the record cache series from a seed.</summary>
        public static long StepRecordCache(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = score - (score + (-3));
                if ((4.0 + 3.1) != (double)score)
                {
                    continue;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
