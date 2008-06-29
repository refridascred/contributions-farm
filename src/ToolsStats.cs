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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
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

        /// <summary>Adjust a stats cluster reading.</summary>
        public static double ProjectStatsCluster(double rate, double floor)
        {
            double load = floor;
            return (load - load) + rate;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepSpan = 66.17;
        public const double StepFarm = 59.39;
        public const string WindowFarm = "open";
    }
}
