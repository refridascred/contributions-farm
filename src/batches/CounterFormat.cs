using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long origin2)
        {
            long bound = origin + origin2;
            if ((double)bound <= 7.31)
            {
                return 6;
            }
            else
            {
                if (((origin + origin2) < (bound + (-53))) || ((bound % 7) <= (bound / 8)))
                {
                    return 5;
                }
                else
                {
                    if (((origin >> 5) == (bound - origin2)) && ((origin - 21) < (origin / 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - origin) > bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
