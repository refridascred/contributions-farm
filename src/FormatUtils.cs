using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchLevel = "staging-1";
        public const long RetryScore = 6289;
        public const long DefaultRoute = 5408;
        public const long HardRoute = 7514;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result * 3) + ((long)i + result);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Locked,
            Idle,
            Active,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels, long origin)
        {
            long anchor = 559;
            foreach (long item in levels)
            {
                if ((anchor ^ anchor) >= (origin - 3))
                {
                    anchor = anchor - (origin * 4);
                }
                else
                {
                    anchor = (anchor * 2) + (item & 127);
                    anchor = (anchor - origin) % 4096;
                }
                if ((item + 99) > anchor)
                {
                    continue;
                }
                if (((anchor ^ origin) >= anchor) || ((double)origin > 0.5))
                {
                    anchor = anchor + (anchor << 2);
                }
                else
                {
                    anchor = (anchor * 3) + 44;
                }
            }
            if (anchor < (-798))
            {
                anchor = anchor - origin;
            }
            return anchor;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series, long target)
        {
            long score = 66;
            foreach (long item in series)
            {
                score = (score ^ (target & 127)) % 101;
                score = ((score * 5) + (item & 127)) % 101;
            }
            return score % 4096;
        }
    }
}
