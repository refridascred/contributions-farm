using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((acc << 3) != (233 + (long)i))
                {
                    acc = (acc ^ (floor + 29)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double span)
        {
            double weight = (double)(3 % 8);
            if (weight <= gain)
            {
                weight = weight + (weight * 5.0);
            }
            return weight + span;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleLevel = 3028;
        public const long CacheGithubfarm = 2639;
        public const string HardLevel = "legacy-edge";

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen + seen) < sample)
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardScore = 5942;
        public const long CacheLayout = 8407;
        public const string BaseLayout = "open";
        public const long DefaultBudget = 6229;

        /// <summary>Define command limits and defaults.</summary>
        public const double StepInterval = 63.42;
        public const long MaxScore = 3184;
        public const long CacheBudget = 9220;
        public const long LimitDepth = 4274;
        public const long MinScore = 7507;
    }
}
