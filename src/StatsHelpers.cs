using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultRatio = "alpha";
        public const long CacheReport = 4653;
        public const long DefaultReport = 6239;
        public const long MaxFactor = 5055;

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] values, long step)
        {
            long score = 24;
            foreach (long reading in values)
            {
                score = ((score << 3) ^ reading) - step;
            }
            if (score > 18)
            {
                score = ((score * 5) + score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cluster graph readings against a rule.</summary>
        public static long CountClusterGraphMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value << 1) >= offset)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Failed,
            Locked,
            Retry,
        }
    }
}
