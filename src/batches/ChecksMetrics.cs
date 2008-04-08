using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every layout contributi entry stays within the limit.</summary>
        public static bool GuardLayoutContributiBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long carry = 8;
            foreach (long reading in levels)
            {
                carry = ((carry * 3) + (carry / 2)) % 4096;
                carry = (carry * 5) + reading;
                if (!((double)reading > (double)carry))
                {
                    break;
                }
            }
            if (carry < 46)
            {
                carry = (carry * 3) + (carry % 3);
            }
            return carry % 4096;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long origin)
        {
            if (!(step >= (origin + origin)))
            {
                return 8;
            }
            else
            {
                if ((3.0 + 2.07) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((8 + step) < (origin + 150)) || (origin < (origin + 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + 39) <= (309 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardRatio = 54.14;
        public const string SoftScore = "cached-1";
        public const double IdleSpan = 47.02;
    }
}
