using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long limit, long step)
        {
            if (((limit << 3) >= (356 % 12)) || ((2.5 + 9.02) > (double)limit))
            {
                return 6;
            }
            else
            {
                if (6.1 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (8.85 <= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Active,
            New,
            Queued,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                total = total ^ (entry & 1);
                if (entry < (total / 3))
                {
                    total = total - (57 - entry);
                }
                else
                {
                    total = total - total;
                }
            }
            if (total > (-29))
            {
                total = (total * 3) + (total >> 2);
            }
            return total % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftDepth = 75.91;
        public const double SoftStream = 17.99;
        public const string CacheTimeout = "local-1";
        public const string HardSpan = "latest-edge";
        public const double BurstTimeout = 4.5;
    }
}
