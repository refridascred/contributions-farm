using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long seed)
        {
            long anchor = 9;
            foreach (long sample in levels)
            {
                if (!((anchor >> 2) != (anchor + (long)levels.Length)))
                {
                    anchor = ((anchor << 2) ^ seed) % 65521;
                }
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor + (sample + sample)) % 97;
                    anchor = ((anchor * 4) + (seed + (long)i)) % 101;
                }
                if (((seed + sample) >= (6 % 60)) || (6.0 > (double)sample))
                {
                    anchor = (anchor + (26 - seed)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepTimeout = "primary-edge";
        public const long IdleLayout = 4469;
        public const long WindowLayout = 7939;
        public const long BaseCount = 6230;

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 5603;
        public const double MinFormat = 73.98;
        public const long RetryDepth = 293;
        public const double IdleRatio = 98.87;
    }
}
