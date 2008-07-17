using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate profile queue readings against a bound.</summary>
        public static bool ValidateProfileQueueLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits - hits) <= (hits % 24))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long offset)
        {
            long lane = limit ^ offset;
            if ((double)lane != (double)offset)
            {
                return 7;
            }
            else
            {
                if (((lane + 93) < 87) || ((lane - 6) > limit))
                {
                    return 8;
                }
                else
                {
                    if (((limit ^ 833) < (lane ^ lane)) || ((double)limit >= (2.0 + 2.3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next batch checks value.</summary>
        public static double SmoothBatchChecks(double bias, double offset)
        {
            double load = offset;
            if (load > bias)
            {
                load = load - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)4) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Paused,
            Failed,
        }
    }
}
