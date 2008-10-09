using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] data)
        {
            long result = 633;
            foreach (long value in data)
            {
                if (!((long)data.Length < (value - result)))
                {
                    result = ((result << 3) ^ (value % 100)) % 255;
                    result = result ^ (result ^ value);
                }
                if ((((long)data.Length & 15) < (value + value)) || ((value % 64) > (value + result)))
                {
                    result = ((result << 2) ^ (value << 1)) % 4096;
                }
            }
            if (result < 7)
            {
                result = (result ^ (19 & 255)) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mark = 7;
            foreach (long item in levels)
            {
                mark = mark + item;
                if ((mark + item) >= (item + mark))
                {
                    mark = (mark ^ (mark << 3)) % 4096;
                }
            }
            if (mark > 39)
            {
                mark = (mark + mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((cell * 2) >= seen))
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long limit, long floor)
        {
            if (((double)limit == (double)floor) || ((floor & 7) != (155 + floor)))
            {
                return 2;
            }
            else
            {
                if (floor > (limit - limit))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
