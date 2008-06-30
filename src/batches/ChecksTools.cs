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

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long offset)
        {
            long prev = target + offset;
            if (((4.0 * 16.0) < (double)offset) && ((272 << 1) > offset))
            {
                return 1;
            }
            else
            {
                if ((77 - offset) <= (offset << 3))
                {
                    return 3;
                }
                else
                {
                    if (target >= (58 ^ prev))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + prev) >= prev) && ((prev / 8) > target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
