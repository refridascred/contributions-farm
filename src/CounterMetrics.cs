using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double scale, double span)
        {
            double mean = scale * 17.0;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean + span)) + (double)(long)i;
            }
            return mean + (double)7;
        }

        /// <summary>Count the payload route entries that pass the check.</summary>
        public static long AuditPayloadRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry - tally) < (entry << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (2 > tally)
                {
                    tally = ((tally + 3) + entry) + offset;
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
