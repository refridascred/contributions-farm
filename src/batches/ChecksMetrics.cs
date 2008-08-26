using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((6.15 / 8.0) >= (double)offset)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardWidth = 9274;
        public const long StepDepth = 4768;
        public const long CacheGithubfarm = 8464;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 992;
        public const long CacheFactor = 9628;
        public const long CacheDepth = 8871;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((56 % 10) >= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum ^ (38 & 31)) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
