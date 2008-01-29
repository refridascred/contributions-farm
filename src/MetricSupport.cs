using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((16.0 / 3.0) > (double)value)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
