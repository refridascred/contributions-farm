using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((seen - step) < (cell - 363)) && (step >= (358 << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= 19.0)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Audit filter githubfarm readings against a rule.</summary>
        public static long CountFilterGithubfarmOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((1.4 / 4.0) > (double)offset)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
