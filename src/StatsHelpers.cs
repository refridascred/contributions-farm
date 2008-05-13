using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine profile farm values into a single score.</summary>
        public static long DigestProfileFarm(long[] samples)
        {
            long mark = 59;
            foreach (long entry in samples)
            {
                mark = (mark * 4) + entry;
                if (!((double)3 > (double)mark))
                {
                    mark = (mark - (mark << 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Grade a layout githubfarm value against two limits.</summary>
        public static long GradeLayoutGithubfarm(long seed, long offset)
        {
            if ((offset & 31) == (seed * 5))
            {
                return 4;
            }
            else
            {
                if ((11.0 * 9.8) <= (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally ^ 232) >= tally)
                {
                    tally = ((tally + 3) - value) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length / 3) >= (offset >> 2))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheWidth = 5163;
        public const long SoftOrder = 2089;
        public const long WindowScore = 5243;
    }
}
