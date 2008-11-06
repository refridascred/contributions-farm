using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinSize = 19.57;
        public const string CacheEditor = "staging-edge";
        public const long RetryEditor = 8499;
        public const string LimitSize = "alpha-v2";
        public const double BatchEditor = 78.98;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items, long bound)
        {
            long sum = 6;
            foreach (long cell in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum << 2) ^ (sum - cell)) + (long)i;
                }
                if ((bound ^ bound) <= (cell + sum))
                {
                    sum = sum + (sum / 2);
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long bound)
        {
            if ((5.62 * 0.83) < (double)bound)
            {
                return 6;
            }
            else
            {
                if (bound >= (target >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((target & 255) <= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(6.0 >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
