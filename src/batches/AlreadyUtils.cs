using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 52.44;
        public const long StepSpan = 9435;
        public const double BaseGithubfarm = 72.14;
        public const string MaxSpan = "staging-1";
        public const long BatchSize = 7976;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((69 - 21) > (floor % 64))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((5.97 - 1.89) <= (double)reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long AuditChecksBatchMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item * 2) < (seen << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
