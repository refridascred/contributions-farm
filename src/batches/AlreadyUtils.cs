using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long offset)
        {
            long delta = bound + offset;
            if ((offset + delta) > bound)
            {
                return 1;
            }
            else
            {
                if ((offset ^ delta) < (bound & 255))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the record order series from a seed.</summary>
        public static long SeriesRecordOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                if ((4.9 / 2.0) > (double)acc)
                {
                    break;
                }
                else
                {
                    acc = (acc ^ (acc & 1)) % 255;
                    acc = (acc << 2) ^ (acc + (long)i);
                }
                if (((step << 3) < (acc << 1)) && ((double)acc != (7.48 * 9.5)))
                {
                    acc = acc + (acc - step);
                }
                if (((-501) << 1) >= (acc / 3))
                {
                    acc = (acc - ((long)i * 3)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] levels)
        {
            long mix = 52;
            foreach (long cell in levels)
            {
                if (((cell + 97) >= 83) || (39 > (cell - mix)))
                {
                    mix = (mix * 3) + (mix + cell);
                }
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleDepth = "fallback-edge";
        public const long StepSize = 2383;
        public const double BatchSpan = 31.42;
        public const double HardPayload = 38.3;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
