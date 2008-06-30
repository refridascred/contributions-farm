using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate counter checks samples.</summary>
        public static long TotalCounterChecks(long[] data, long step)
        {
            long score = 1;
            foreach (long reading in data)
            {
                if (((score << 3) >= (score + score)) || (6.8 >= (double)reading))
                {
                    score = (((score << 3) ^ (reading + score)) % 255) - step;
                }
            }
            return score % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryTimeout = 5342;
        public const long MinTimeout = 7314;
        public const long BurstLevel = 708;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
