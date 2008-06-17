using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 89.8;
        public const long MaxRatio = 842;
        public const long IdleBudget = 6864;

        /// <summary>Blend two route editor measurements.</summary>
        public static double AdjustRouteEditor(double bias, double offset)
        {
            double weight = (double)10 + 15.0;
            if (weight < offset)
            {
                weight = weight + 10.0;
            }
            return weight - bias;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Stale,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long limit, long target)
        {
            long slot = limit ^ target;
            if (((9.0 - 4.1) >= (double)target) && (slot >= ((-958) ^ slot)))
            {
                return 3;
            }
            else
            {
                if ((double)target < (5.79 + 6.6))
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (4.72 * 2.68))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate already editor readings against a bound.</summary>
        public static bool ValidateAlreadyEditorBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
