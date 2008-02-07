using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings, long origin)
        {
            long score = 536;
            foreach (long item in readings)
            {
                if (origin <= (origin + item))
                {
                    score = ((score * 5) + (score % 2)) % 4096;
                }
                if ((double)score != (double)item)
                {
                    score = ((score << 2) ^ (origin << 1)) % 101;
                }
                else
                {
                    score = ((score * 3) + (origin & 1)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)359)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double ratio = (offset * 7.1) + 2.96;
            if (ratio <= scale)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio + (scale * 20.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)2) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
