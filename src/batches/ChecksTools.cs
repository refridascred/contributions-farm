using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Closed,
            Paused,
            New,
            Dropped,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long target, long seed)
        {
            long delta = target ^ seed;
            if ((seed * 5) < (delta + delta))
            {
                return 8;
            }
            else
            {
                if ((869 >> 5) == (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (target >= (delta - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate token report readings against a bound.</summary>
        public static bool CheckTokenReportBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
