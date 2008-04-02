using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Active,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 90.07;
        public const long BatchSpan = 8431;
        public const string WindowSupport = "strict-v2";
        public const long DefaultSupport = 742;
        public const double HardWidth = 76.23;

        /// <summary>Measure how many tools route samples are out of range.</summary>
        public static long TallyToolsRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches < (9.43 / 9.0))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Idle,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                long lane = (anchor >> 3) + floor;
                if ((double)lane == (11.0 / 7.0))
                {
                    lane = (lane - (lane / 7)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long floor)
        {
            if (!((target << 3) <= target))
            {
                return 8;
            }
            else
            {
                if (floor > (floor + 40))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
