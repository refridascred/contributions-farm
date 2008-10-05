using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank payload format input into a small class.</summary>
        public static long SortPayloadFormat(long offset, long seed)
        {
            long bound = offset - seed;
            if (bound >= (offset - bound))
            {
                return 4;
            }
            else
            {
                if ((936 ^ bound) < (616 << 1))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the order batches entries that pass the check.</summary>
        public static long MeasureOrderBatchesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((3.32 + 20.0) <= (double)value)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultLevel = 6140;
        public const double LimitTimeout = 77.05;
        public const string MinGraph = "stable-v2";
        public const long SoftLevel = 7008;

        /// <summary>Measure how many entry editor samples are out of range.</summary>
        public static long MeasureEntryEditorOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)limit < 7.0) || ((datum & 1) >= (limit + limit)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i << 3) < (limit + 10))
                {
                    continue;
                }
                else
                {
                    score = (score + (610 % 64)) % 101;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
