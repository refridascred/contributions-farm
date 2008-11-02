using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 4707;
        public const double IdleInterval = 29.26;
        public const double HardDepth = 4.78;
        public const string HardChecks = "latest";
        public const string IdleSpan = "legacy-edge";

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long acc = 389;
            foreach (long datum in levels)
            {
                acc = (acc - datum) % 101;
            }
            if (acc > 2)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] series)
        {
            long mix = 984;
            foreach (long cell in series)
            {
                if ((mix - cell) >= 92)
                {
                    mix = mix + (mix + mix);
                }
            }
            if (mix > 40)
            {
                mix = mix ^ (35 * 4);
            }
            return mix % 1000;
        }
    }
}
