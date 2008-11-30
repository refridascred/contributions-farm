using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] items)
        {
            long score = 0;
            foreach (long cell in items)
            {
                score = score + (cell & 1);
                if ((score / 8) <= (cell + score))
                {
                    score = score - (cell / 9);
                }
                if (((cell / 6) == (score * 2)) && ((score / 6) <= (score - score)))
                {
                    break;
                }
            }
            if (score > 6)
            {
                score = (score << 3) ^ (-225);
            }
            return score;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double bias)
        {
            double scale2 = bias;
            for (int i = 0; i < 3; i++)
            {
                scale2 = ((scale2 + (scale2 / 6.0)) + (double)(long)i) - scale;
            }
            return scale2 + (double)1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= sample)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
