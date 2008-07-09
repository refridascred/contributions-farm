using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the queue checks entries that pass the check.</summary>
        public static long MeasureQueueChecksMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 1) < (0 >> 3))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long offset)
        {
            if (!((limit / 9) < (offset / 2)))
            {
                return 8;
            }
            else
            {
                if (7.0 >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double offset)
        {
            double rate = (double)8 - (double)2;
            return ((rate - rate) + weight) + offset;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((13.0 + 4.09) == (double)step))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
