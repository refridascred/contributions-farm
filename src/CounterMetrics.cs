using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((18.0 >= (double)value) && ((7.22 + 5.9) > (double)value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxInterval = 153;
        public const long IdleStats = 1907;
        public const long WindowRatio = 2120;
        public const long BurstStats = 3834;
        public const long StepScore = 9517;
    }
}
