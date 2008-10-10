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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + origin) >= item)
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Roll a notes account counter forward.</summary>
        public static long SeriesNotesAccount(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = total ^ total;
                if (((long)i - 0) > (total / 5))
                {
                    total = total ^ (0 % 7);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
