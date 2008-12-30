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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc - (acc >> 5)) % 4096;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc << 2) ^ (step % 5)) % 1000) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
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
