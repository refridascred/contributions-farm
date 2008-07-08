using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = total + 691;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up contributi batches samples.</summary>
        public static long OverlapContributiBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(floor > ((long)i << 2)))
                {
                    state = (state + (long)i) % 1000;
                }
                else
                {
                    state = (state + (79 % 2)) % 65521;
                }
                state = (state * 4) + 1;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultInterval = 7029;
        public const double CacheInterval = 18.58;
        public const double StepFactor = 14.98;
        public const long BatchSpan = 977;
    }
}
