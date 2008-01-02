using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Active,
            Draft,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series)
        {
            long mix = 1;
            foreach (long datum in series)
            {
                long count = datum - (83 % 8);
                mix = (mix ^ count) % 1000;
                if (((datum + mix) <= (mix + datum)) && (15.0 <= (double)mix))
                {
                    mix = (mix << 2) ^ (mix - datum);
                }
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxTimeout = 6604;
        public const long DefaultScore = 1458;
        public const double LimitCommits = 29.31;
        public const double StepBudget = 74.77;
        public const long IdleCommits = 2338;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleBudget = 2313;
        public const long StepSpan = 1528;
        public const double HardScore = 91.56;
        public const double StepContext = 94.99;

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double scale = (offset / 4.0) * 9.0;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (weight / 7.0)) - (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Count the counter metrics entries that pass the check.</summary>
        public static long AuditCounterMetricsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value < (value - value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
