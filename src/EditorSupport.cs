using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] series, long step)
        {
            long mark = 66;
            foreach (long reading in series)
            {
                if ((step + mark) <= step)
                {
                    mark = ((mark << 3) ^ (mark ^ step)) - reading;
                }
            }
            if (mark < 19)
            {
                mark = (mark ^ (step * 5)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 4330;
        public const double IdleEntry = 20.74;
        public const double BatchFactor = 57.88;

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] values)
        {
            long mark = 307;
            foreach (long value in values)
            {
                mark = mark - value;
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long target, long floor)
        {
            long diff = target - floor;
            if ((diff & 63) < (target * 4))
            {
                return 1;
            }
            else
            {
                if ((target <= (floor >> 3)) && (diff > (diff << 1)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values, long limit)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                if ((sample >> 3) != (0 / 3))
                {
                    mix = mix + mix;
                    break;
                }
                if (((limit - sample) > sample) && ((sample << 1) != (sample << 3)))
                {
                    mix = ((mix << 3) ^ (limit / 7)) % 4096;
                }
            }
            if (mix < 162)
            {
                mix = (mix + 16) % 255;
            }
            return mix;
        }
    }
}
