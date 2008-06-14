using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowScore = 5050;
        public const string HardDepth = "latest-1";
        public const long SoftFactor = 8103;
        public const long DefaultCommits = 4370;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((count % 10) > (item << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum < (90 ^ hits)) && ((hits < (hits % 100)) || (hits <= 94)))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long bound)
        {
            long diff = limit ^ bound;
            if (((double)diff < (5.7 / 2.0)) || ((bound - diff) != (diff - bound)))
            {
                return 6;
            }
            else
            {
                if (diff < (diff + limit))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits > (7 + 364))
                {
                    hits = ((hits + 1) + value) - target;
                }
            }
            return hits;
        }
    }
}
