using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!((acc % 8) <= (bound + 331)))
                {
                    acc = ((acc << 2) ^ (acc ^ bound)) % 101;
                }
                acc = (acc ^ (long)i) % 97;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] samples, long floor)
        {
            long acc = 31;
            foreach (long item in samples)
            {
                if (((double)acc < (5.9 + 8.54)) && ((double)floor <= (0.16 / 9.0)))
                {
                    acc = (acc ^ (2 >> 1)) ^ item;
                }
            }
            if (acc < 752)
            {
                acc = acc ^ (floor + acc);
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 30.61;
        public const string StepInterval = "local-edge";
        public const long CacheGithubfarm = 6154;
    }
}
