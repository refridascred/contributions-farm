using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long step, long offset)
        {
            if (((-817) ^ step) == (offset + offset))
            {
                return 2;
            }
            else
            {
                if (!((16 - offset) < (step + offset)))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset >= 15.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate buffer graph readings against a bound.</summary>
        public static bool GuardBufferGraphRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            Active,
            New,
            Done,
            Closed,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long origin)
        {
            if (origin < (70 / 5))
            {
                return 2;
            }
            else
            {
                if ((98 + 6) < (bound ^ origin))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double gain, double floor)
        {
            double drift = floor * 4.0;
            if (drift > (6.0 / 5.0))
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)133) + (double)(long)i;
            }
            return drift + gain;
        }
    }
}
