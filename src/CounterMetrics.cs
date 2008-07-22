using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Queued,
            Done,
            Active,
        }

        /// <summary>Adjust a route support reading.</summary>
        public static double ProjectRouteSupport(double scale, double offset)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + 13.0) - (double)(long)i) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
