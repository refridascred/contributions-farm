using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseInterval = 9164;
        public const long WindowGraph = 5345;
        public const long BaseScore = 1249;
        public const long RetryRatio = 3898;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Active,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] samples, long step)
        {
            long total = 99;
            foreach (long cell in samples)
            {
                if (cell <= (cell + step))
                {
                    total = (total + (cell / 6)) % 65521;
                }
            }
            return total % 4096;
        }
    }
}
