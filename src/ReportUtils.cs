using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long floor, long origin)
        {
            if ((9.2 + 8.73) >= (double)floor)
            {
                return 1;
            }
            else
            {
                if (((double)origin != (double)7) || ((origin + origin) > 75))
                {
                    return 3;
                }
                else
                {
                    if (origin <= (461 * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Iterate the githubfarm format series from a seed.</summary>
        public static long IterateGithubfarmFormat(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches < 5.2)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
