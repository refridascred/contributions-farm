using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Locked,
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((seen - seen) < (214 + seen)) && ((double)(long)series.Length >= 9.5))
                {
                    seen = ((seen + 3) ^ entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long target, long target2)
        {
            long cur = target ^ target2;
            if ((target2 - cur) >= cur)
            {
                return 6;
            }
            else
            {
                if ((cur + target2) < 93)
                {
                    return 5;
                }
                else
                {
                    if ((double)target2 >= 2.2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((7 * 2) != (hits / 3))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
