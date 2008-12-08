using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 4425;
        public const double DefaultDepth = 63.55;
        public const double BatchSession = 14.09;
        public const long MaxLevel = 2022;
        public const long IdleTimeout = 4193;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix + (mix & 63)) % 255;
                mix = ((mix * 5) + ((long)i + mix)) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 38.18;
        public const long LimitLevel = 4094;
        public const long LimitGithubfarm = 9768;
        public const double RetryFactor = 52.63;

        /// <summary>Validate already metrics readings against a bound.</summary>
        public static bool CheckAlreadyMetricsBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits < (double)sample)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
