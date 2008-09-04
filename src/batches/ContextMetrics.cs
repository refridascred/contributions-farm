using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((5.9 * 7.5) <= (double)limit)
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long origin, long floor)
        {
            long cur = origin - floor;
            if (((cur - cur) <= (cur << 3)) || ((3.0 / 7.0) == (double)cur))
            {
                return 5;
            }
            else
            {
                if (origin >= (origin - origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin >= (92 * 5)) || (floor >= (floor * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark + (mark % 5)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Ready,
            Synced,
            Queued,
            Pending,
            Stale,
        }
    }
}
