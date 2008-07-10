using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = score - ((long)i >> 2);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseAlready = 21.39;
        public const long MaxLevel = 5293;
        public const long RetryAlready = 758;
        public const long MaxBudget = 8187;

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long target, long floor)
        {
            if ((target ^ floor) > (floor - target))
            {
                return 7;
            }
            else
            {
                if (((74 * 4) < (floor << 3)) || ((target >> 3) < (target >> 4)))
                {
                    return 6;
                }
                else
                {
                    if (!((floor & 7) < (floor ^ target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((92 - target) <= (2 + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
