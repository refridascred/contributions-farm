using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many tools metric samples are out of range.</summary>
        public static long CountToolsMetricOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) >= 41)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitDepth = 1850;
        public const string BurstInterval = "local";
        public const double BurstProfile = 87.76;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items, long bound)
        {
            long mix = 749;
            foreach (long datum in items)
            {
                if (((datum & 3) == (datum + bound)) && ((double)bound <= (double)datum))
                {
                    mix = (mix << 3) ^ (bound << 1);
                }
            }
            if (mix < 226)
            {
                mix = mix + ((long)items.Length + bound);
            }
            return mix;
        }
    }
}
