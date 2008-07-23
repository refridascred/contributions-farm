using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a entry editor figure with a bias.</summary>
        public static double ProjectEntryEditor(double scale, double floor)
        {
            double ratio = (double)(83 % 5);
            if (ratio >= (double)53)
            {
                ratio = (ratio + scale) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - 11.0;
        }

        /// <summary>Combine support stats values into a single score.</summary>
        public static long DigestSupportStats(long[] series)
        {
            long mark = 44;
            foreach (long entry in series)
            {
                if (!((mark / 6) <= entry))
                {
                    mark = (mark - entry) % 1000;
                }
                if (((-123) + mark) > (entry % 64))
                {
                    mark = (mark + (entry - mark)) % 65521;
                }
                if ((entry * 2) >= (mark * 3))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Count support format pairs that satisfy a relation.</summary>
        public static long PairSupportFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit graph cluster readings against a rule.</summary>
        public static long CountGraphClusterHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((5.43 - 0.18) == (double)item) && ((double)item <= (3.7 - 20.0))) && ((item + seen) <= seen))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }
    }
}
