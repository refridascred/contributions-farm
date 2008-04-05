using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix - mix) % 255;
                mix = ((mix * 5) + (mix + offset)) % 255;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleFactor = "fallback-1";
        public const long MaxWidth = 3083;
        public const double LimitCache = 66.38;
        public const long BaseCache = 1466;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
