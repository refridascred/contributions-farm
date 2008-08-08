using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next queue cluster value.</summary>
        public static double SmoothQueueCluster(double weight, double offset)
        {
            double rate = weight;
            if (rate <= (13.0 * 16.0))
            {
                rate = rate - (double)(-90);
            }
            return rate - (offset * 0.7);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading >> 2) < ((long)values.Length - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
