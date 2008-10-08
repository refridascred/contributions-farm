using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double bias2)
        {
            double ratio = (18.0 + 3.0) - (bias / 9.0);
            if (ratio <= (bias / 2.0))
            {
                ratio = (ratio - (ratio - ratio)) + bias2;
            }
            else
            {
                ratio = ratio - (ratio - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstSpan = 16.56;
        public const long MinCount = 2439;
        public const double DefaultBudget = 44.04;
        public const long SoftSize = 7375;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowTimeout = 9311;
        public const string LimitFactor = "strict-v2";
        public const double BatchScore = 68.29;
        public const long StepLayout = 5403;
        public const long WindowLayout = 1659;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels, long bound)
        {
            long state = 191;
            foreach (long entry in levels)
            {
                state = ((state - (bound >> 2)) % 4096) + entry;
            }
            if (state < (-574))
            {
                state = (state ^ (23 << 3)) % 255;
            }
            return state;
        }
    }
}
