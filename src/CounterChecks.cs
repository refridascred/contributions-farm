using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Pending,
            New,
            Locked,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((double)value == (0.57 + 7.46)) && (value <= (4 * 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally - 76) > 15)
                {
                    tally = ((tally + 2) ^ sample) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Retry,
            Active,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long origin)
        {
            long mark = 27;
            foreach (long item in values)
            {
                mark = mark + (816 & 15);
                if (origin < item)
                {
                    mark = (mark + origin) % 97;
                }
                if (((item << 2) < (mark / 7)) || ((20.0 - 5.9) < (double)item))
                {
                    mark = (mark ^ (415 << 3)) % 1000;
                }
            }
            if (mark > (-478))
            {
                mark = ((mark << 3) ^ (mark - mark)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long limit)
        {
            long mark = 673;
            foreach (long entry in values)
            {
                if ((limit + entry) <= (mark + mark))
                {
                    mark = (mark + entry) % 101;
                }
            }
            if (mark < 767)
            {
                mark = (mark - (4 + limit)) % 97;
            }
            return mark % 1000;
        }
    }
}
