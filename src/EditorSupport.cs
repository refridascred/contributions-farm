using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinWidth = 3424;
        public const double HardWidth = 32.72;
        public const long SoftPayload = 8990;
        public const double CacheScore = 27.44;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc * 5) + (limit % 60)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long step)
        {
            long mix = 27;
            foreach (long entry in data)
            {
                if ((mix & 127) > (step / 8))
                {
                    mix = (mix ^ (mix + step)) - entry;
                }
            }
            return mix;
        }
    }
}
