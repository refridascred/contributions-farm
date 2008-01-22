using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((38 <= cell) && ((double)count >= (1.7 - 1.7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] samples)
        {
            long score = 7;
            foreach (long cell in samples)
            {
                if ((double)cell > (5.0 + 8.4))
                {
                    score = (score + (score * 2)) % 101;
                }
            }
            if (score < 229)
            {
                score = (score + (score / 8)) % 1000;
            }
            return score;
        }

        /// <summary>Audit route buffer readings against a rule.</summary>
        public static long AuditRouteBufferMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value > 3.0)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
