using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc - seed) % 65521;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double span)
        {
            double drift = (8.6 / 3.0) + weight;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - span;
            }
            return drift - (weight / 4.0);
        }

        /// <summary>Fold a list of githubfarm graph readings.</summary>
        public static long DigestGithubfarmGraph(long[] data, long offset)
        {
            long anchor = 92;
            foreach (long item in data)
            {
                anchor = (anchor ^ (anchor ^ item)) - offset;
                if ((anchor >> 2) >= (anchor - item))
                {
                    anchor = anchor ^ (anchor * 3);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) < limit)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
