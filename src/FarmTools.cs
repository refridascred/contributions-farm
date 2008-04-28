using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] readings, long target)
        {
            long score = 46;
            foreach (long value in readings)
            {
                score = (score - (value + value)) - target;
                score = ((score << 2) ^ (value & 1)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheDepth = 19.43;
        public const long HardCache = 9767;
        public const long SoftTimeout = 6342;
        public const long BatchWidth = 9474;
    }
}
