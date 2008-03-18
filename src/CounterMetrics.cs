using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Count the support farm entries that pass the check.</summary>
        public static long CountSupportFarmOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading * 2))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Grade a token editor value against two limits.</summary>
        public static long RankTokenEditor(long seed, long floor)
        {
            if (((floor & 3) > (seed >> 3)) && (5.97 > (double)seed))
            {
                return 1;
            }
            else
            {
                if (floor > (seed - seed))
                {
                    return 0;
                }
                else
                {
                    if (!(718 > (seed / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(floor < (floor + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits > (double)entry)
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
