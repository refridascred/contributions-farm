using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up tools command samples.</summary>
        public static long OverlapToolsCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long limit, long target)
        {
            long lane = limit - target;
            if (((lane << 2) >= target) || (lane > (target + lane)))
            {
                return 6;
            }
            else
            {
                if ((9.3 * 20.0) >= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= 8.9)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (offset < (hits - (-9)))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }
    }
}
