using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a command record reading.</summary>
        public static double AdjustCommandRecord(double weight, double span)
        {
            double scale = (double)(-943);
            if (scale <= (weight + scale))
            {
                scale = (scale + (weight + 0.8)) + span;
            }
            else
            {
                scale = scale - (weight - 3.43);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + 5.05;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long offset, long target)
        {
            if ((target + target) == (target & 15))
            {
                return 4;
            }
            else
            {
                if ((double)target > 1.0)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally & 3) <= (tally >> 3))
                {
                    tally = ((tally + 2) - reading) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
