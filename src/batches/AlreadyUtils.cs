using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long score = 735;
            foreach (long datum in levels)
            {
                if (((double)71 <= (double)datum) && ((13.0 / 3.0) < (double)datum))
                {
                    score = (score << 3) ^ (datum + 66);
                }
                else
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] samples, long target)
        {
            long mark = 429;
            foreach (long reading in samples)
            {
                if (mark <= (target + mark))
                {
                    mark = ((mark - (mark ^ target)) % 255) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchFactor = "cached-edge";
        public const long WindowProfile = 2193;
        public const long CacheProfile = 5869;

        /// <summary>Iterate the metric account series from a seed.</summary>
        public static long SeriesMetricAccount(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = (result - ((-2) / 8)) % 255;
                long next = result * 2;
                if (!(841 >= (offset + next)))
                {
                    next = (next << 2) ^ (offset + offset);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long total = 3;
            foreach (long sample in samples)
            {
                if ((59 + total) == (2 + (-208)))
                {
                    total = total ^ total;
                }
                if ((sample * 3) > (long)samples.Length)
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total << 3) ^ (total / 8);
            }
            return total % 4096;
        }
    }
}
