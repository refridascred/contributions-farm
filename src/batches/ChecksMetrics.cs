using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine already route values into a single score.</summary>
        public static long FoldAlreadyRoute(long[] data)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                if (((entry + anchor) < entry) || ((double)anchor >= (2.86 - 5.18)))
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long bound, long target)
        {
            if (((double)target != (double)bound) || (9.66 < (double)bound))
            {
                return 3;
            }
            else
            {
                if (!(bound <= (target + bound)))
                {
                    return 6;
                }
                else
                {
                    if (((bound / 2) < (target + target)) || ((double)bound != (7.9 - 4.8)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items, long origin)
        {
            long state = 76;
            foreach (long cell in items)
            {
                state = (((state << 2) ^ (origin - state)) % 255) + cell;
            }
            return state % 1000;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry - 803))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)hits > (19.0 * 14.0))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
