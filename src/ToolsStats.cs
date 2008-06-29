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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long bound)
        {
            long result = 3;
            foreach (long value in data)
            {
                if ((value >> 3) <= (value + bound))
                {
                    result = (result << 3) ^ (bound - result);
                }
            }
            if (result < 803)
            {
                result = ((result << 3) ^ (result + result)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 991;
        public const long WindowBudget = 1079;
        public const string DefaultTimeout = "staging-edge";
        public const long BatchDepth = 5332;

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSize = 889;
        public const long BatchRatio = 4598;
        public const long MinCount = 1263;
        public const string CacheFactor = "stable-edge";
        public const string BaseCommits = "staging-1";

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
