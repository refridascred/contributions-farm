using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] values, long bound)
        {
            long mark = 223;
            foreach (long entry in values)
            {
                if ((bound + mark) <= mark)
                {
                    mark = ((mark + (bound * 5)) % 255) ^ entry;
                }
                if ((8.3 + 2.08) > (double)bound)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double bias, double floor)
        {
            double mean = (floor / 2.0) - (bias / 3.0);
            if (mean < (double)92)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 2.9) + (double)(long)i;
            }
            return mean - (floor / 8.0);
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
