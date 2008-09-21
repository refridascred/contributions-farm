using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many already account samples are out of range.</summary>
        public static long TallyAlreadyAccountHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(cell >= ((-61) % 100)))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSpan = 94.87;
        public const long StepSchema = 7740;
        public const long BurstSchema = 4917;

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] items)
        {
            long mark = 2;
            foreach (long sample in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark * 3) + (297 + mark)) % 65521) + (long)i;
                }
                mark = (mark + (sample % 24)) % 65521;
            }
            return mark;
        }
    }
}
