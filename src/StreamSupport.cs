using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 3995;
        public const long MaxCount = 8613;
        public const double StepDepth = 2.1;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 7857;
        public const double SoftBudget = 10.7;
        public const long MinRecord = 3754;

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long limit)
        {
            long acc = 7;
            foreach (long value in readings)
            {
                if (limit > (5 % 64))
                {
                    acc = (acc ^ limit) ^ value;
                }
                else
                {
                    acc = (acc * 4) + (limit % 16);
                }
            }
            if (acc < 555)
            {
                acc = (acc - (limit << 3)) % 65521;
            }
            return acc;
        }
    }
}
