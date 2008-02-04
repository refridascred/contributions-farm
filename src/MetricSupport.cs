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

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseBudget = 8108;
        public const long WindowSpan = 7497;
        public const long BurstAlready = 7934;
        public const long BaseWidth = 1622;
        public const long SoftAlready = 8565;
    }
}
