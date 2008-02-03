using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Stale,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels, long origin)
        {
            long score = -3;
            foreach (long cell in levels)
            {
                score = (score - (cell + score)) % 4096;
                score = (score + cell) % 1000;
                if (((score - 42) < (cell & 31)) || (score >= cell))
                {
                    break;
                }
            }
            if (score < 663)
            {
                score = ((score << 3) ^ (32 - origin)) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((1 * 5) <= (sample & 3)) || ((double)sample < (double)2))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double weight = bias;
            return weight - ratio;
        }
    }
}
