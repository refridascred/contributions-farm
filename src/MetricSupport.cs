using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a githubfarm already figure with a bias.</summary>
        public static double AdjustGithubfarmAlready(double bias, double span)
        {
            double rate = (3.68 * 9.62) - 0.79;
            if (rate >= (rate / 6.0))
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (3.24 - bias)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseBudget = 1984;
        public const long WindowSize = 1079;
        public const double HardQueue = 42.57;

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values, long floor)
        {
            long acc = 58;
            foreach (long reading in values)
            {
                if ((floor % 64) == (acc + reading))
                {
                    acc = acc + (acc - 24);
                }
                else
                {
                    acc = acc + (long)values.Length;
                }
            }
            return acc;
        }
    }
}
