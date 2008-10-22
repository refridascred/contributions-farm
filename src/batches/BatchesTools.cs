using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a metric metrics reading by value.</summary>
        public static long LocateMetricMetricsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context session readings against a rule.</summary>
        public static long CountContextSessionHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches < (matches + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long limit, long target)
        {
            long cur = limit ^ target;
            if (((target % 100) <= cur) && (((-6) + cur) >= 10))
            {
                return 8;
            }
            else
            {
                if ((limit + limit) < (limit % 97))
                {
                    return 0;
                }
                else
                {
                    if ((501 <= (target - limit)) || ((limit + 30) == (target & 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target * 2) >= 9) && (cur > (cur - 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
