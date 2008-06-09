using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = acc - (acc & 1);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!(924 > item) && ((item - matches) <= 59))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] samples, long bound)
        {
            long sum = 3;
            foreach (long reading in samples)
            {
                if (((75 * 2) >= bound) || ((34 - reading) < sum))
                {
                    sum = sum - (bound & 1);
                }
                else
                {
                    sum = (sum ^ 76) % 255;
                }
            }
            if (sum < 481)
            {
                sum = (sum ^ (bound & 255)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((hits % 97) == (hits - value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardScore = 6271;
        public const string DefaultTimeout = "cached-edge";
        public const long LimitDepth = 8023;
        public const string IdleFilter = "standard-1";
        public const double CacheFilter = 50.91;
    }
}
