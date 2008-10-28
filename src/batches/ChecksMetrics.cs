using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long offset)
        {
            if ((offset * 3) <= bound)
            {
                return 2;
            }
            else
            {
                if ((bound & 31) == (bound % 60))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 3) < (0 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) != (offset ^ 105))
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinDepth = 4034;
        public const double WindowRatio = 91.31;
        public const double LimitStats = 50.16;
        public const long MaxScore = 4092;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long bound, long bound2)
        {
            long slot = bound + bound2;
            if ((bound >= 84) && ((9.7 + 14.0) == (double)bound2))
            {
                return 8;
            }
            else
            {
                if (((bound2 / 6) <= (560 + bound2)) && ((double)slot >= (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] series)
        {
            long mark = 607;
            foreach (long value in series)
            {
                if ((mark & 1) <= value)
                {
                    mark = (mark ^ (5 + value)) % 65521;
                }
                else
                {
                    mark = (mark + (mark - value)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinBudget = 721;
        public const string MinEntry = "cached";
        public const long RetryEntry = 5373;
    }
}
