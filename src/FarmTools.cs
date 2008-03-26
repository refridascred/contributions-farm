using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 9434;
        public const long BaseScore = 7792;
        public const long IdleGraph = 2234;
        public const long MinGraph = 6995;

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long target)
        {
            long total = 350;
            foreach (long datum in samples)
            {
                if (((9.0 + 2.7) >= (double)datum) || (((-13) % 3) > (target ^ total)))
                {
                    total = ((total * 5) + (datum >> 5)) % 101;
                }
                total = (total << 3) ^ (992 - (long)samples.Length);
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 3821;
        public const double HardContributi = 57.11;
        public const double RetryWidth = 83.56;
    }
}
