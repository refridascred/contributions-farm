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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell - tally) >= (tally * 5)) && ((cell & 15) > ((long)samples.Length * 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
