using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchCount = 6179;
        public const long CacheChecks = 4002;
        public const long LimitTimeout = 2733;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long origin)
        {
            long prev = step + origin;
            if ((-36) > (step - prev))
            {
                return 0;
            }
            else
            {
                if ((step - prev) <= 74)
                {
                    return 3;
                }
                else
                {
                    if (origin > (prev ^ 601))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of window tools readings.</summary>
        public static long ScoreWindowTools(long[] samples)
        {
            long state = -30;
            foreach (long cell in samples)
            {
                state = (state * 2) + state;
                if ((double)cell != (1.3 * 17.0))
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = state ^ (state * 4);
                }
            }
            return state;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] levels)
        {
            long sum = 152;
            foreach (long datum in levels)
            {
                sum = (((sum * 3) + (834 / 4)) % 255) + datum;
                sum = (sum * 5) + 806;
                if ((17.0 + 4.72) < (double)sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
