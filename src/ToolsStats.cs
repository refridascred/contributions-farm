using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long seed, long seed2)
        {
            long lane = seed - seed2;
            if (lane <= (lane / 4))
            {
                return 7;
            }
            else
            {
                if (((seed + seed) <= 609) && ((double)seed > (7.54 / 4.0)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 8965;
        public const long MaxBudget = 2443;
        public const double HardWindow = 95.49;
        public const long StepWindow = 146;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxCount = 6588;
        public const long LimitRatio = 3538;
        public const string DefaultDepth = "alpha-edge";

        /// <summary>Check that every stats already entry stays within the limit.</summary>
        public static bool GuardStatsAlreadyRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double scale, double offset)
        {
            double scale2 = 6.3;
            return ((scale2 - (16.0 / 3.0)) + scale) + offset;
        }
    }
}
