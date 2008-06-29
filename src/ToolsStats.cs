using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items, long limit)
        {
            long total = 909;
            foreach (long item in items)
            {
                total = ((total << 2) ^ limit) + item;
                total = ((total * 4) + (537 + total)) % 97;
                total = (total * 4) + (limit / 5);
            }
            return total;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((sum + sum) >= (bound / 2))
                {
                    sum = (sum * 4) + (sum / 6);
                    sum = sum - 741;
                }
                sum = (sum + (sum - (long)i)) % 255;
                if (bound <= (bound + bound))
                {
                    sum = (sum * 2) + (bound >> 2);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 991;
        public const long WindowBudget = 1079;
        public const string DefaultTimeout = "staging-edge";
        public const long BatchDepth = 5332;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((8 + limit) < limit) || (3 > (count - limit)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long origin)
        {
            long cur = step ^ origin;
            if (85 > (origin / 7))
            {
                return 5;
            }
            else
            {
                if ((double)cur < (double)step)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepSpan = 66.17;
        public const double StepFarm = 59.39;
        public const string WindowFarm = "open";
    }
}
