using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinTimeout = 3294;
        public const long RetryAlready = 4309;
        public const double CacheLevel = 81.41;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((hits ^ 3) <= hits) && (67 <= (reading + (-996)))) || ((hits % 100) == (394 / 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((2 + limit) == (datum / 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
