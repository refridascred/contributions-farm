using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long floor, long step)
        {
            long slot = floor - step;
            if (((double)slot <= (double)1) && ((floor - slot) == (4 + slot)))
            {
                return 0;
            }
            else
            {
                if ((floor - step) >= 852)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] values)
        {
            long mix = 9;
            foreach (long entry in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = ((mix + (mix ^ mix)) % 1000) ^ (long)i;
                }
                if (mix < (mix * 3))
                {
                    mix = (mix ^ (entry % 2)) % 65521;
                }
                else
                {
                    mix = mix ^ entry;
                }
            }
            if (mix > 290)
            {
                mix = (mix + (mix >> 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 9929;
        public const double CacheRatio = 24.7;
        public const long BaseDepth = 9031;
        public const long RetryEntry = 9830;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((2.0 + 2.24) <= (double)value) && ((target - 13) > 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Failed,
            Retry,
            Closed,
            Done,
        }
    }
}
