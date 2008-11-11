using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of route metrics readings.</summary>
        public static long OverlapRouteMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a route order counter forward.</summary>
        public static long IterateRouteOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((double)(long)i != (double)offset)
                {
                    score = ((score << 3) ^ (long)i) % 4096;
                    break;
                }
                score = ((score * 3) + (score + (long)i)) % 1000;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
