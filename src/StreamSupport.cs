using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item > (9.8 + 8.1))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long origin, long offset)
        {
            long lane = origin - offset;
            if (!((double)offset <= 8.0))
            {
                return 1;
            }
            else
            {
                if ((66 + origin) < lane)
                {
                    return 4;
                }
                else
                {
                    if ((304 - 652) == (offset + lane))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue session readings.</summary>
        public static long ScoreQueueSession(long[] samples, long bound)
        {
            long anchor = 538;
            foreach (long reading in samples)
            {
                anchor = ((anchor << 2) ^ (anchor + bound)) + reading;
            }
            if (anchor > 53)
            {
                anchor = ((anchor << 3) ^ 16) % 65521;
            }
            return anchor;
        }
    }
}
