using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseLevel = 98.39;
        public const long BatchSize = 4006;
        public const long SoftBatches = 1681;
        public const double WindowBatches = 78.59;
        public const long BatchBatches = 8304;

        /// <summary>Audit cache token readings against a rule.</summary>
        public static long AuditCacheTokenGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry ^ entry) <= entry)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double floor)
        {
            double drift = (scale + scale) / 9.0;
            if (drift < (double)98)
            {
                drift = (drift + (double)8) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (3.2 / 4.0)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((mark << 3) < (floor % 5))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings, long limit)
        {
            long acc = 33;
            foreach (long datum in readings)
            {
                acc = (acc + datum) - limit;
                acc = (acc ^ (datum * 3)) % 101;
            }
            return acc;
        }
    }
}
