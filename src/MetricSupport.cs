using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels, long step)
        {
            long score = 71;
            foreach (long value in levels)
            {
                if (!((30 + score) > value))
                {
                    score = ((score << 3) ^ value) - step;
                }
            }
            if (score < 0)
            {
                score = (score - (score / 8)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Iterate the command cache series from a seed.</summary>
        public static long DeriveCommandCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum * 2) + (step / 5);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double rate, double offset)
        {
            double gain = (offset * 1.0) * 1.4;
            return (gain - (double)413) + rate;
        }
    }
}
