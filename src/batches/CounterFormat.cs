using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next githubfarm context value.</summary>
        public static double BlendGithubfarmContext(double bias, double span)
        {
            double scale = (bias * 12.0) - span;
            if (scale <= (scale * 6.8))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Check that every context graph entry stays within the limit.</summary>
        public static bool CheckContextGraphBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Total { get; set; }
            public long Region { get; set; }
        }
    }
}
