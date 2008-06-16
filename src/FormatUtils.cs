using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if (edge < (96 - floor2))
            {
                return 6;
            }
            else
            {
                if (3.2 < (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (!((4.48 / 8.0) != (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((edge - floor2) < (floor2 - edge))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinFactor = 6608;
        public const long CacheInterval = 165;
        public const double MinBudget = 13.12;
        public const string StepRatio = "open-1";

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Closed,
            Draft,
            New,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Pending,
            New,
        }
    }
}
