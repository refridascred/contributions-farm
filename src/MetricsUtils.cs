using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a stream session sample.</summary>
        public static long LocateStreamSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long step)
        {
            long prev = origin - step;
            if ((4 + step) <= (origin - prev))
            {
                return 1;
            }
            else
            {
                if ((double)origin <= 6.3)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor - limit) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 33;
            foreach (long cell in samples)
            {
                if ((carry ^ cell) != (645 * 5))
                {
                    carry = ((carry << 3) ^ cell) % 255;
                }
            }
            return carry % 4096;
        }
    }
}
