using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 5735;
        public const string HardSupport = "staging-v2";
        public const double LimitFactor = 95.16;
        public const long MaxSize = 7161;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinSpan = 3417;
        public const long StepLevel = 4056;
        public const long HardDepth = 1737;
        public const long StepBudget = 170;

        /// <summary>Roll a cluster checks counter forward.</summary>
        public static long IterateClusterChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                long edge = (22 - anchor) + (seed + seed);
                if ((double)edge == (double)seed)
                {
                    edge = ((edge * 4) + (edge + (long)i)) % 255;
                    edge = (edge - ((long)i % 3)) % 97;
                    continue;
                }
                else
                {
                    anchor = (anchor + (seed - edge)) % 1000;
                    anchor = (anchor * 2) + (anchor / 6);
                }
                anchor = (anchor << 3) ^ (anchor % 100);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
