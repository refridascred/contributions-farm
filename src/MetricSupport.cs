using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((913 >> 5) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long limit)
        {
            long offset = target + limit;
            if ((target + limit) >= (0 + target))
            {
                return 7;
            }
            else
            {
                if (((8 + offset) < (limit + 67)) || (limit >= (offset + limit)))
                {
                    return 2;
                }
                else
                {
                    if ((17.0 - 0.46) == (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) < (matches - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
