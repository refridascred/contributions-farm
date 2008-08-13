using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank contributi checks input into a small class.</summary>
        public static long BucketContributiChecks(long offset, long offset2)
        {
            if ((offset2 - offset) >= (36 + offset))
            {
                return 7;
            }
            else
            {
                if (((15.0 / 4.0) >= (double)offset2) && ((offset2 + 69) < (offset % 2)))
                {
                    return 0;
                }
                else
                {
                    if ((10.0 + 14.0) < (double)offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset - offset2) <= (offset / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (limit <= (seen / 2))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
