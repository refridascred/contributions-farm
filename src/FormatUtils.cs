using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long target2)
        {
            if (target > (222 << 1))
            {
                return 4;
            }
            else
            {
                if (((7 >> 5) >= (target2 + target)) && (target < (target - target2)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheAlready = "standard-v2";
        public const double MinInterval = 52.1;
        public const string LimitWidth = "latest";

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Failed,
            Stale,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(value < (bound << 3)) || ((bound % 100) < bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster support readings against a rule.</summary>
        public static long MeasureClusterSupportOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits == (9.57 + 7.16))
                {
                    hits = ((hits + 3) ^ sample) + limit;
                }
            }
            return hits;
        }
    }
}
