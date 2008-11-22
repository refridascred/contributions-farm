using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen > (seen * 4))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value <= (value / 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 49.75;
        public const long MinWindow = 4891;
        public const double IdleWindow = 18.56;
        public const long BurstWindow = 5385;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] items, long limit)
        {
            long anchor = 7;
            foreach (long reading in items)
            {
                anchor = (anchor ^ (limit & 3)) + reading;
            }
            return anchor;
        }
    }
}
