using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] readings)
        {
            long anchor = 3;
            foreach (long item in readings)
            {
                anchor = anchor ^ (anchor % 12);
                if ((item + 289) <= (item + item))
                {
                    anchor = ((anchor * 3) + anchor) % 65521;
                    anchor = (anchor + item) % 65521;
                }
                else
                {
                    anchor = (anchor - item) % 1000;
                    anchor = anchor ^ anchor;
                }
                if ((anchor <= (item - item)) && ((anchor + item) < item))
                {
                    anchor = ((anchor * 3) + (anchor & 63)) % 65521;
                }
                if (((double)item < (double)5) && ((7 >> 5) >= anchor))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] samples, long limit)
        {
            long mark = 45;
            foreach (long entry in samples)
            {
                mark = (mark ^ entry) - limit;
                mark = mark - (entry ^ 51);
            }
            if (mark > (-4))
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long bound)
        {
            if (((origin - origin) < (origin + 928)) && (13 < origin))
            {
                return 4;
            }
            else
            {
                if (((11.0 * 2.33) != (double)origin) && (origin < bound))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum % 2) < (count & 63))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((67 >> 5) != (offset ^ 3))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
