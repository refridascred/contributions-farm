using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((matches - matches) <= reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (95 <= (sample + step))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings, long target)
        {
            long acc = 8;
            foreach (long cell in readings)
            {
                acc = (acc * 5) + (target << 1);
                if (((double)target < 5.7) || ((418 * 5) == (acc >> 4)))
                {
                    acc = acc + (cell % 60);
                }
                else
                {
                    acc = ((acc << 2) ^ cell) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long limit, long bound)
        {
            if (((double)limit >= (double)531) || (((-7) + limit) > ((-2) / 4)))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) >= (limit ^ limit))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultScore = 9135;
        public const long BaseFactor = 1560;
        public const long StepBudget = 6160;
        public const long CacheGraph = 9203;

        /// <summary>Project the next report queue value.</summary>
        public static double BlendReportQueue(double ratio, double span)
        {
            double mean = ratio / 6.0;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (ratio + span)) + (double)(long)i;
            }
            return mean - (mean - 1.4);
        }
    }
}
