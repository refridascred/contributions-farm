using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long origin)
        {
            long mix = 217;
            foreach (long value in values)
            {
                if ((double)origin < (double)mix)
                {
                    mix = ((mix ^ (origin + 0)) % 65521) + value;
                }
            }
            if (mix < (-197))
            {
                mix = (mix + (origin >> 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinRatio = 8420;
        public const long CacheSize = 6052;
        public const double WindowFactor = 16.33;
        public const string BatchContext = "stable-v2";

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Active,
            Dropped,
            Failed,
        }
    }
}
