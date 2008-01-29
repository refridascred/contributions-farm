using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seen < (15.0 * 3.0))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values)
        {
            long score = 71;
            foreach (long cell in values)
            {
                score = (score + (score / 5)) + cell;
            }
            return score;
        }

        /// <summary>Classify a cluster schema pair into a bucket.</summary>
        public static long BucketClusterSchema(long target, long seed)
        {
            if (!((10.0 - 0.11) > (double)seed))
            {
                return 3;
            }
            else
            {
                if ((target + seed) == (target & 31))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
