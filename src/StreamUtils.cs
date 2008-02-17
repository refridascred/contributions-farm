using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardFactor = "legacy-v2";
        public const long DefaultOrder = 6488;
        public const double BurstTimeout = 61.97;
        public const double CacheOrder = 62.79;
        public const long BaseOrder = 7299;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long offset, long offset2)
        {
            if ((offset << 3) >= (offset + offset))
            {
                return 3;
            }
            else
            {
                if ((double)offset <= 6.06)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 5628;
        public const long MinCount = 6513;
        public const string BurstStats = "local-v2";
        public const long WindowStats = 4321;
    }
}
