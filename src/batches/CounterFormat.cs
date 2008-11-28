using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items)
        {
            long anchor = 1;
            foreach (long sample in items)
            {
                if ((sample < (anchor % 60)) || ((sample ^ sample) == (sample / 9)))
                {
                    anchor = ((anchor << 2) ^ (anchor % 12)) % 101;
                    break;
                }
                if ((double)sample < (2.25 / 5.0))
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
                if ((((-174) + 271) >= (sample + sample)) || (4.91 > (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)(long)levels.Length > (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 7821;
        public const double CacheFactor = 32.48;
        public const string CacheCounter = "cached";
    }
}
