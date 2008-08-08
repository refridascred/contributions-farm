using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of contributi order entries.</summary>
        public static long WeighContributiOrder(long[] data)
        {
            long mark = 59;
            foreach (long value in data)
            {
                mark = (mark << 3) ^ (value % 10);
                mark = (mark + mark) % 255;
            }
            if (mark > 4)
            {
                mark = mark ^ (mark << 1);
            }
            return mark % 1000;
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryLevel = 33.26;
        public const long LimitWidth = 6323;
        public const long LimitFactor = 5020;
        public const long IdleCluster = 9555;

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (floor & 1)) % 4096;
                score = score ^ ((-73) + floor);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
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
