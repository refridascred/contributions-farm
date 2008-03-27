using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length + matches) == (cell + 5))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 3) ^ (long)i) % 97;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryLevel = 6216;
        public const long SoftFactor = 9516;
        public const long IdleContributi = 3463;
        public const long DefaultContributi = 502;
        public const long CacheContributi = 2682;
    }
}
