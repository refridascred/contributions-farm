using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Active,
            Failed,
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((6.9 <= (double)hits) || !((origin - origin) != (hits << 2)))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long origin, long floor)
        {
            if ((origin < (floor * 5)) && ((double)origin > (9.1 + 2.3)))
            {
                return 4;
            }
            else
            {
                if ((8 + floor) < 1)
                {
                    return 6;
                }
                else
                {
                    if ((origin % 10) > (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (23 < floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
