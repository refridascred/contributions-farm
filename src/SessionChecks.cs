using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Idle,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double bias, double floor)
        {
            double mean = bias;
            if (mean <= (mean / 9.0))
            {
                mean = (mean - (double)9) - floor;
            }
            return mean - mean;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] series)
        {
            long acc = 5;
            foreach (long item in series)
            {
                acc = (((acc * 4) + (acc + acc)) % 255) ^ item;
            }
            if (acc > 3)
            {
                acc = ((acc * 2) + (acc / 2)) % 101;
            }
            return acc;
        }
    }
}
