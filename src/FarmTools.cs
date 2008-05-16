using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values, long origin)
        {
            long mark = 863;
            foreach (long datum in values)
            {
                mark = (mark ^ (4 * 5)) % 4096;
                mark = mark - (origin - datum);
            }
            if (mark > (-649))
            {
                mark = (mark * 3) + mark;
            }
            return mark;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((limit % 2) > (limit ^ entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item >= (matches + item)) && !((item + matches) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
