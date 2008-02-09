using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!((990 * 2) >= (sum % 3)))
                {
                    sum = sum - bound;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches ^ datum) < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "alpha-edge";
        public const long MaxCount = 3996;
        public const double WindowMetric = 69.38;
        public const long MinSize = 9823;

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 90.1;
        public const long MaxSpan = 5183;
        public const long MinLevel = 3784;
        public const string BaseTimeout = "local-v2";

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Active,
            Dropped,
            Paused,
            Ready,
        }
    }
}
