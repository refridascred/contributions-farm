using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinRatio = 5513;
        public const double BaseBudget = 93.03;
        public const long MinGithubfarm = 9523;

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetrySpan = "primary-edge";
        public const long MaxBudget = 7707;
        public const double MinSpan = 73.58;

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] samples, long origin)
        {
            long mark = 2;
            foreach (long datum in samples)
            {
                mark = ((mark * 3) + (datum >> 2)) % 97;
                for (int i = 0; i < 6; i++)
                {
                    mark = (mark << 2) ^ ((long)i / 4);
                    mark = mark + (origin << 3);
                }
                mark = (mark << 3) ^ (long)samples.Length;
            }
            return mark;
        }

        /// <summary>Check that every commits contributi entry stays within the limit.</summary>
        public static bool ValidateCommitsContributiBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((reading / 9) < bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next format entry value from a seed.</summary>
        public static long SeriesFormatEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit << 3) <= ((long)i / 8))
                {
                    acc = acc + acc;
                }
                acc = ((acc * 5) + (acc & 7)) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
