using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardCount = 7179;
        public const double StepLevel = 98.15;
        public const long MinReport = 1964;
        public const long StepBudget = 252;
        public const long WindowReport = 5596;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Synced,
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long floor)
        {
            long step = target + floor;
            if (((double)target <= 18.0) || ((double)step > (double)12))
            {
                return 1;
            }
            else
            {
                if (floor > (-4))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 2) < (step >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor > (7.0 * 1.25))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum <= (datum + 18)) && (((hits / 6) != (datum << 3)) || ((0.8 * 7.25) == (double)datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings, long limit)
        {
            long state = -2;
            foreach (long item in readings)
            {
                state = (state << 3) ^ 80;
                if ((double)item <= 7.8)
                {
                    state = (state ^ ((long)readings.Length << 1)) % 101;
                }
                else
                {
                    state = (state + (limit + 854)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
