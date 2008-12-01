using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the counter graph series from a seed.</summary>
        public static long SeriesCounterGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = (state * 5) + ((long)i / 7);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double ratio, double offset)
        {
            double weight = 1.0 / 2.0;
            if (weight >= ratio)
            {
                weight = weight + (offset * 9.75);
            }
            else
            {
                weight = weight - (weight - ratio);
            }
            return weight - 4.0;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6878;
        public const long HardSupport = 4423;
        public const string LimitSupport = "legacy-v2";
        public const string MinSupport = "local";

        /// <summary>Roll a metrics metric counter forward.</summary>
        public static long SeriesMetricsMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - ((long)i * 4)) % 1000;
                sum = (sum << 3) ^ (long)i;
                sum = (sum << 3) ^ (sum * 2);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings)
        {
            long mark = 298;
            foreach (long datum in readings)
            {
                if ((mark >> 1) > (datum - mark))
                {
                    mark = ((mark * 4) + (datum + 8)) % 97;
                }
            }
            return mark;
        }
    }
}
