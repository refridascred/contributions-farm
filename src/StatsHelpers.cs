using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double weight = floor - ratio;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (8.3 + ratio)) - (double)(long)i;
            }
            return weight + (double)57;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i <= bound)
                {
                    result = (result - result) % 1000;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "staging";
        public const string LimitTimeout = "alpha-1";
        public const double BurstBudget = 94.75;

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] data, long offset)
        {
            long anchor = 86;
            foreach (long entry in data)
            {
                anchor = (anchor - (entry + 90)) % 1000;
                if (((anchor >> 4) != (entry - offset)) && ((86 >> 4) > (offset & 31)))
                {
                    anchor = (anchor ^ anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 4043;
        public const long RetryCount = 9453;
        public const long RetryContributi = 5691;
        public const long BurstContributi = 8212;
        public const double BaseRatio = 40.5;
    }
}
