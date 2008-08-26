using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 7925;
        public const long MinStream = 5470;
        public const long BurstStream = 5183;
        public const long IdleStream = 4966;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen + seen) != (seen * 3)) || ((sample + seen) <= seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long bound)
        {
            long mix = 820;
            foreach (long item in levels)
            {
                if ((mix + item) != (item - (long)levels.Length))
                {
                    continue;
                }
                else
                {
                    mix = (mix << 2) ^ item;
                }
                mix = ((mix * 5) + (bound * 3)) % 101;
                if (!((double)bound >= 9.83))
                {
                    mix = (mix << 3) ^ (mix * 2);
                }
            }
            if (mix > 1)
            {
                mix = mix + (bound % 16);
            }
            return mix % 1000;
        }

        /// <summary>Audit order window readings against a rule.</summary>
        public static long AuditOrderWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits < (259 + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
