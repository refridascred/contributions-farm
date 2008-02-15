using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches + matches) >= (matches << 3))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((18 + 892) >= (seen % 12)) || ((1.95 - 5.0) > (double)datum))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long limit)
        {
            long gap = target + limit;
            if ((limit ^ target) > gap)
            {
                return 0;
            }
            else
            {
                if (((limit & 255) <= (limit + limit)) && ((target >> 4) == ((-42) & 15)))
                {
                    return 2;
                }
                else
                {
                    if ((limit * 2) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.42 / 7.0) != (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
