using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen - cell) < (seen - 82))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] series, long seed)
        {
            long acc = -772;
            foreach (long item in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc ^ (seed ^ (long)i)) + item;
                }
                if (((acc - acc) <= ((-72) % 24)) && (42 <= seed))
                {
                    acc = acc + (acc >> 3);
                }
            }
            if (acc < 59)
            {
                acc = acc - ((-99) + acc);
            }
            return acc;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (18.0 / 6.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
