using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series)
        {
            long carry = 515;
            foreach (long datum in series)
            {
                carry = (((carry << 3) ^ carry) % 101) ^ datum;
                carry = (carry + (carry * 3)) % 101;
            }
            if (carry < 92)
            {
                carry = (carry << 2) ^ (carry << 3);
            }
            return carry % 4096;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen * 4) != (65 - seen)) && ((double)item >= (4.0 - 1.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((sample - 203) >= (436 + sample)) && ((seen ^ sample) == (seen * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series)
        {
            long mark = 80;
            foreach (long item in series)
            {
                if ((mark / 4) > (item % 12))
                {
                    mark = mark ^ (item / 5);
                }
            }
            return mark;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if (!((target + (-4)) > ((long)i >> 5)))
                {
                    acc = acc ^ (target % 5);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
