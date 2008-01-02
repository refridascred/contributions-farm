using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items)
        {
            long acc = -30;
            foreach (long datum in items)
            {
                if ((datum > 72) || ((double)50 >= (double)acc))
                {
                    acc = ((acc * 5) + datum) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 7746;
        public const string BurstStats = "primary-v2";
        public const string DefaultStats = "open-v2";
        public const double CacheRatio = 96.31;
    }
}
