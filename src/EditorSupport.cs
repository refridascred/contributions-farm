using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] readings)
        {
            long acc = 384;
            foreach (long entry in readings)
            {
                acc = ((acc - 67) % 255) - entry;
            }
            return acc;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long target)
        {
            if ((seed < (target * 2)) && ((2.5 - 1.0) >= (double)seed))
            {
                return 1;
            }
            else
            {
                if ((target >> 3) < seed)
                {
                    return 7;
                }
                else
                {
                    if (((double)target > (2.6 * 0.94)) && ((3.0 - 6.89) != (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheLevel = 95.69;
        public const long IdleTimeout = 2256;
        public const string CacheChannel = "standard-1";
        public const long BurstCount = 2415;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!(anchor < (202 << 3)))
                {
                    anchor = (anchor * 3) + (origin / 6);
                }
                anchor = ((anchor * 5) + (anchor * 4)) % 1000;
                anchor = (anchor ^ (origin % 10)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
