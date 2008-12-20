using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = mix ^ (501 >> 2);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((8.85 / 5.0) != (double)seed) || (anchor >= (seed % 97)))
                {
                    anchor = anchor ^ (seed - anchor);
                }
                else
                {
                    anchor = (anchor << 2) ^ (seed * 2);
                }
                if (!((seed & 1) < 61))
                {
                    anchor = anchor ^ (anchor ^ (long)i);
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 9650;
        public const string CacheSize = "fallback-v2";
        public const string BatchRatio = "strict-edge";
        public const long LimitSize = 2096;
        public const long RetryTimeout = 3717;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinSize = 8341;
        public const double MinAlready = 11.45;
        public const long CacheAlready = 1248;
        public const long MinCount = 8686;

        /// <summary>Combine githubfarm report values into a single score.</summary>
        public static long TotalGithubfarmReport(long[] samples)
        {
            long anchor = -951;
            foreach (long sample in samples)
            {
                anchor = (anchor ^ anchor) % 4096;
                if (!((sample << 1) == (sample / 8)))
                {
                    break;
                }
            }
            if (anchor > (-475))
            {
                anchor = (anchor ^ (anchor << 3)) % 65521;
            }
            return anchor % 97;
        }
    }
}
