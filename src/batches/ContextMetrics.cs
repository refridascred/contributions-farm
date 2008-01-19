using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxDepth = "legacy-edge";
        public const long BurstContributi = 4244;
        public const string SoftContributi = "standard-1";
        public const long MinBudget = 6245;

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data)
        {
            long anchor = 775;
            foreach (long entry in data)
            {
                anchor = (anchor - ((long)data.Length % 8)) + entry;
                if ((double)anchor < 9.6)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long offset)
        {
            if (!((double)step >= (9.2 * 6.81)))
            {
                return 4;
            }
            else
            {
                if (!((offset / 4) < (step % 16)))
                {
                    return 7;
                }
                else
                {
                    if ((8 << 3) <= (54 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long origin, long target)
        {
            if (((origin >> 3) > (target + target)) && ((origin ^ 7) >= (origin + target)))
            {
                return 2;
            }
            else
            {
                if ((target * 5) < (origin - origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
