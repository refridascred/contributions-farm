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

        /// <summary>Project the next filter profile value.</summary>
        public static double ScaleFilterProfile(double bias, double span)
        {
            double gain = 5.88 / 5.0;
            if (gain > (span + 7.77))
            {
                gain = (gain + (double)5) + bias;
            }
            return gain - span;
        }
    }
}
