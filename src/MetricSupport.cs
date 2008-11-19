using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits ^ hits) != (8 % 64))
                {
                    hits = ((hits + 3) ^ value) - step;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long step)
        {
            long gap = bound + step;
            if ((bound + bound) >= (gap % 60))
            {
                return 5;
            }
            else
            {
                if (((step + step) > (38 * 5)) || ((7 * 4) < (gap - step)))
                {
                    return 8;
                }
                else
                {
                    if (((867 - gap) == (bound + 8)) && ((bound - step) == (34 - gap)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + (-56)) < step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batch layout input into a small class.</summary>
        public static long ClassifyBatchLayout(long floor, long offset)
        {
            if ((double)offset >= (7.06 + 6.68))
            {
                return 1;
            }
            else
            {
                if ((double)floor == (4.0 + 10.0))
                {
                    return 0;
                }
                else
                {
                    if ((floor + offset) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset < (1 - offset)) && (floor < (offset << 2)))
                        {
                            return 5;
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
