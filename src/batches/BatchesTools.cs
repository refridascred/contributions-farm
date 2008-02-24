using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double bias, double span)
        {
            double bias2 = (double)(51 * 4);
            if (bias2 <= (bias / 4.0))
            {
                bias2 = bias2 - (bias * 2.2);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (bias2 + span)) + (double)(long)i;
            }
            return bias2 - (double)33;
        }
    }
}
