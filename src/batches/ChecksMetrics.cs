using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a layout cache pair into a bucket.</summary>
        public static long GradeLayoutCache(long floor, long seed)
        {
            long bound = floor ^ seed;
            if ((floor % 7) > (bound / 7))
            {
                return 7;
            }
            else
            {
                if (bound >= (6 + floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] levels)
        {
            long mix = 6;
            foreach (long cell in levels)
            {
                if ((double)cell >= (5.54 - 2.1))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = (mix + cell) % 101;
                }
            }
            if (mix < 60)
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }

        /// <summary>Derive the next report profile value from a seed.</summary>
        public static long StepReportProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - acc) % 255) ^ (long)i2;
                    acc = (acc * 5) + (floor - acc);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data)
        {
            long mark = 5;
            foreach (long value in data)
            {
                if ((value >> 2) >= (mark * 5))
                {
                    mark = mark - (2 >> 5);
                }
                mark = (mark - (mark & 7)) % 255;
            }
            if (mark > 9)
            {
                mark = ((mark << 2) ^ ((-5) >> 4)) % 255;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepInterval = "latest-edge";
        public const long LimitSpan = 9236;
        public const long SoftWidth = 2123;
        public const double BaseStats = 43.04;
        public const long SoftRatio = 3291;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
