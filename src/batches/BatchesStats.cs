using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long offset, long offset2)
        {
            long slot = offset - offset2;
            if ((offset2 < (offset2 << 3)) || (offset > (slot / 6)))
            {
                return 1;
            }
            else
            {
                if ((double)offset2 >= (18.0 + 6.5))
                {
                    return 5;
                }
                else
                {
                    if (((slot + slot) < (offset2 % 100)) && ((slot % 60) < (offset & 255)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)slot >= (6.7 + 2.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((4.42 + 1.0) == (double)tally)
                {
                    tally = ((tally + 3) + entry) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Idle,
            Dropped,
        }
    }
}
