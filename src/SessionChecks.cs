using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate githubfarm stream samples.</summary>
        public static long TotalGithubfarmStream(long[] levels)
        {
            long mark = 25;
            foreach (long cell in levels)
            {
                if ((double)cell < 9.78)
                {
                    mark = (mark << 3) ^ ((-89) + mark);
                }
            }
            if (mark > (-41))
            {
                mark = ((mark << 2) ^ ((long)levels.Length + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Count the metric schema entries that pass the check.</summary>
        public static long CountMetricSchemaHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) >= datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count + value) >= (value - count)))
                {
                    count = (count + 2) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "primary-edge";
        public const long HardCount = 4433;
        public const long StepBudget = 9579;
    }
}
