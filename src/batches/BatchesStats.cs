using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (67 > (bound % 64))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long bound)
        {
            long slot = target - bound;
            if ((double)target == (10.0 / 5.0))
            {
                return 1;
            }
            else
            {
                if (((-74) ^ bound) > (slot * 5))
                {
                    return 4;
                }
                else
                {
                    if (!(11 >= (482 + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (7 < target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Paused,
            Queued,
            Active,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((85 <= (origin - origin)) || ((origin - origin) != (origin + (long)i))))
                {
                    score = (score << 2) ^ (score - 7);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
