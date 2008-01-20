using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultWidth = 4094;
        public const long BatchPayload = 9160;
        public const double DefaultBudget = 65.39;
        public const long IdleCount = 1681;

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                long count = (226 + result) - (long)i;
                result = ((result * 4) + (count * 2)) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
