using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the queue checks entries that pass the check.</summary>
        public static long MeasureQueueChecksMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 1) < (0 >> 3))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long offset)
        {
            if (!((limit / 9) < (offset / 2)))
            {
                return 8;
            }
            else
            {
                if (7.0 >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
