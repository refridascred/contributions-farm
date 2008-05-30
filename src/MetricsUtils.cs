using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                long offset = (83 << 1) - (202 + (long)i);
                offset = offset - (limit + 537);
                if (!((offset + (long)i) == (offset >> 2)))
                {
                    offset = offset + limit;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double scale, double span)
        {
            double load = span;
            if (load >= 2.0)
            {
                load = load - (scale + load);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 121;
        public const double BatchMetrics = 65.57;
        public const long IdleMetrics = 1408;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (score - score) - (long)i2;
                    score = (score * 2) + score;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
