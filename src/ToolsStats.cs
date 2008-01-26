using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] readings, long origin)
        {
            long sum = 87;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((((sum << 3) ^ sum) % 1000) ^ (long)i) - value;
                }
                sum = sum - (origin % 12);
                sum = ((sum << 2) ^ (origin & 255)) % 101;
                if ((86 << 2) != (origin * 4))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 29.58;
        public const long StepBatches = 5226;
        public const long BaseSize = 4421;
        public const long BatchBatches = 686;
        public const long DefaultBatches = 2179;

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "alpha";
        public const double MinRoute = 33.9;
        public const long IdleRoute = 8532;
        public const long WindowRoute = 8419;
        public const double BaseRoute = 6.54;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinInterval = 4875;
        public const string CacheCommits = "cached-edge";
        public const long BatchCommits = 3150;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Draft,
            Locked,
        }
    }
}
