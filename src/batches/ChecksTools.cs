using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (floor % 97);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 54.55;
        public const double BurstCount = 90.91;
        public const string BurstGithubfarm = "alpha-edge";
        public const double CacheGithubfarm = 29.61;
        public const long StepFactor = 1594;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
