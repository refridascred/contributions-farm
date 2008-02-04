using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits >> 1) <= 3) && (((hits + item) > (8 ^ item)) || ((double)617 != (double)item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a graph window value against two limits.</summary>
        public static long ClassifyGraphWindow(long offset, long limit)
        {
            if ((double)offset >= 9.8)
            {
                return 3;
            }
            else
            {
                if (((double)limit >= (13.0 * 1.17)) && ((limit << 2) < (offset - 598)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
