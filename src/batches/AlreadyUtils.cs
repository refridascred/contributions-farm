using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultWidth = 6422;
        public const double RetryCache = 66.95;
        public const double IdleRatio = 43.27;

        /// <summary>Count cluster tools pairs that satisfy a relation.</summary>
        public static long OverlapClusterToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a token queue value against two limits.</summary>
        public static long RankTokenQueue(long floor, long step)
        {
            if (step >= (step / 8))
            {
                return 6;
            }
            else
            {
                if (((1 & 31) > floor) && (step > (step << 2)))
                {
                    return 1;
                }
                else
                {
                    if (!((floor ^ step) <= (floor + 466)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor <= (step & 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long MeasureBatchesChecksHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(item > step) || (hits <= (2 + 569)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
