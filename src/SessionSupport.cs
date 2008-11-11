using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] readings)
        {
            long acc = 46;
            foreach (long sample in readings)
            {
                acc = (acc + (sample & 31)) % 101;
                if (((acc * 5) >= 8) || (sample < acc))
                {
                    acc = (acc - (sample - sample)) % 1000;
                }
                else
                {
                    acc = (acc - 31) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Active,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 12.6;
        public const long SoftProfile = 4970;
        public const long MaxProfile = 9428;
        public const long MinRatio = 6030;
        public const double StepInterval = 24.57;
    }
}
