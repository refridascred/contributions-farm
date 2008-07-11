using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double HardInterval = 87.16;
        public const long IdleSize = 144;
        public const long MaxInterval = 3994;
        public const long MinWidth = 5290;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Paused,
            New,
            Done,
            Active,
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long bound, long offset)
        {
            long delta = bound - offset;
            if ((delta & 7) != (delta - delta))
            {
                return 1;
            }
            else
            {
                if (((-19) - 5) >= (bound % 60))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of schema layout readings.</summary>
        public static long ScoreSchemaLayout(long[] readings, long target)
        {
            long mix = 160;
            foreach (long value in readings)
            {
                mix = ((mix * 3) + target) % 97;
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix << 2) ^ ((-42) + 81)) % 255;
                    mix = (mix ^ (target + (long)i)) % 1000;
                }
                if (((61 - value) == (mix >> 4)) && (target < (target - (-2))))
                {
                    mix = (mix - target) % 101;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ (mix << 1)) % 97;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstCount = 7342;
        public const long CacheLevel = 1470;
        public const long DefaultFactor = 5456;
        public const long CacheBuffer = 570;
    }
}
