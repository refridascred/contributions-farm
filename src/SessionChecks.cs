using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 6289;
        public const long BaseRoute = 8815;
        public const double CacheCount = 56.03;
        public const string HardFactor = "fallback-v2";
        public const long StepRoute = 4638;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 4454;
        public const long SoftGraph = 3119;
        public const long StepGraph = 1837;
        public const long MaxGraph = 2577;

        /// <summary>Measure how many order profile samples are out of range.</summary>
        public static long AuditOrderProfileHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((847 * 4) <= (9 + cell))
                {
                    matches = (matches + 1) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] series, long target)
        {
            long acc = -64;
            foreach (long datum in series)
            {
                if ((datum % 64) == (636 % 97))
                {
                    acc = ((acc * 2) + (target + acc)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ (791 >> 3)) % 97;
                }
            }
            return acc;
        }
    }
}
