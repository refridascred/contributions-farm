using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                long delta = (sum + sum) * 4;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum ^ (delta << 3)) % 4096) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor ^ ((long)i + 88)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many schema profile samples are out of range.</summary>
        public static long AuditSchemaProfileMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value < (7.0 + 3.0))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
