using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample * 3) <= (sample + matches))
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long step)
        {
            if ((4 - step) <= (origin >> 1))
            {
                return 0;
            }
            else
            {
                if ((42 << 3) >= (step - step))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((limit + limit) <= (886 % 64))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
