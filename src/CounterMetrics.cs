using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstBudget = 403;
        public const double CacheSize = 67.89;
        public const double BaseCluster = 53.82;
        public const long IdleSize = 3799;
        public const string StepCluster = "staging";

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] levels)
        {
            long score = -89;
            foreach (long item in levels)
            {
                if (((item + 874) >= (score & 31)) && ((score >> 2) == (item / 9)))
                {
                    score = (score * 5) + (item - item);
                    break;
                }
                if ((13.0 / 4.0) <= (double)item)
                {
                    score = ((score << 3) ^ item) % 97;
                    continue;
                }
                if (61 <= score)
                {
                    score = ((score * 5) + (item & 31)) % 97;
                }
                if (((26 - 658) < (score * 5)) && ((item + item) < (score & 1)))
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = score ^ (score << 3);
            }
            return score;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 1) <= (44 - 49))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double bias = (double)(622 - 91);
            if (bias > (floor + gain))
            {
                bias = bias - (gain - gain);
            }
            else
            {
                bias = bias + (3.04 * 0.9);
            }
            return bias - (gain - 7.0);
        }
    }
}
