using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every batch cache entry stays within the limit.</summary>
        public static bool GuardBatchCacheLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxCount = 17.95;
        public const string IdleProfile = "open";
        public const long LimitProfile = 7565;
        public const double HardCount = 32.09;
        public const long BaseCount = 3712;

        /// <summary>Grade a command tools value against two limits.</summary>
        public static long RankCommandTools(long offset, long origin)
        {
            if ((0 - offset) > (offset + origin))
            {
                return 2;
            }
            else
            {
                if (((double)offset >= (19.0 + 4.0)) || (origin <= 8))
                {
                    return 1;
                }
                else
                {
                    if ((offset / 9) >= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] levels)
        {
            long acc = 53;
            foreach (long sample in levels)
            {
                if ((acc - sample) != (sample & 7))
                {
                    acc = (acc - (76 - sample)) % 97;
                }
            }
            return acc;
        }
    }
}
