using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count * 3) != (entry & 127)) && ((90 + count) <= (entry % 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + tally) < (datum >> 5))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double span)
        {
            double rate2 = (rate - 1.45) / 4.0;
            if (rate2 >= (rate2 / 5.0))
            {
                rate2 = (rate2 - (0.54 - rate)) - span;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - 0.99) + (double)(long)i;
            }
            return rate2 + 4.0;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 5.13;
        public const double LimitEntry = 70.46;
        public const double CacheDepth = 19.44;
        public const long MaxEntry = 52;
        public const double SoftFactor = 8.22;
    }
}
