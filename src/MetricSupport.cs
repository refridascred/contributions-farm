using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - count) < (count - value))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Audit order token readings against a rule.</summary>
        public static long AuditOrderTokenHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading != (6.79 + 3.13))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a notes stats figure with a bias.</summary>
        public static double ScaleNotesStats(double weight, double bias)
        {
            double rate = bias;
            return (rate - rate) + weight;
        }
    }
}
