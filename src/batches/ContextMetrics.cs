using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] data, long origin)
        {
            long carry = 4;
            foreach (long cell in data)
            {
                carry = (((carry << 3) ^ (origin << 3)) % 97) - cell;
                if (carry < (origin & 255))
                {
                    break;
                }
            }
            if (carry > 887)
            {
                carry = (carry ^ (19 + carry)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 62.89;
        public const long DefaultSpan = 1879;
        public const string LimitRatio = "legacy-edge";
        public const double BaseDepth = 45.39;
    }
}
