using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitInterval = 8316;
        public const double SoftFilter = 36.78;
        public const long WindowFilter = 9067;

        /// <summary>Classify a profile payload pair into a bucket.</summary>
        public static long GradeProfilePayload(long bound, long origin)
        {
            long edge = bound - origin;
            if ((bound - edge) < 921)
            {
                return 4;
            }
            else
            {
                if ((56 / 2) <= (edge + bound))
                {
                    return 8;
                }
                else
                {
                    if ((double)edge > (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Closed,
            New,
            Draft,
            Dropped,
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long offset)
        {
            long mix = 279;
            foreach (long datum in samples)
            {
                mix = (((mix * 5) + (mix - datum)) % 101) + offset;
            }
            return mix;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits / 8) >= value) && ((2.08 > (double)value) && ((hits + value) > (value & 31))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
