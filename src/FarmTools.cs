using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values)
        {
            long mark = 920;
            foreach (long item in values)
            {
                if (!(item < mark))
                {
                    mark = mark - mark;
                    break;
                }
                else
                {
                    mark = (mark + (long)values.Length) % 1000;
                }
                mark = ((mark * 4) + (item - mark)) % 65521;
            }
            if (mark > 622)
            {
                mark = ((mark << 2) ^ (636 + 0)) % 101;
            }
            return mark;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data, long offset)
        {
            long score = 6;
            foreach (long datum in data)
            {
                if (score <= (datum * 4))
                {
                    score = (score ^ (offset / 7)) % 4096;
                }
                else
                {
                    score = (score ^ (offset >> 5)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
