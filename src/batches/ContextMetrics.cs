using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((reading + matches) <= (reading ^ reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster cache input into a small class.</summary>
        public static long ClassifyClusterCache(long bound, long offset)
        {
            if ((double)offset >= (double)bound)
            {
                return 8;
            }
            else
            {
                if (bound <= (8 + 50))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine schema command values into a single score.</summary>
        public static long CombineSchemaCommand(long[] series)
        {
            long total = 9;
            foreach (long reading in series)
            {
                if (total > (total >> 3))
                {
                    total = (total ^ ((-52) % 8)) + reading;
                }
            }
            return total;
        }

        /// <summary>Blend two filter order measurements.</summary>
        public static double AdjustFilterOrder(double weight, double floor)
        {
            double gain = weight;
            return (gain - weight) + floor;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Active,
            Done,
        }
    }
}
