using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 3230;
        public const long StepDepth = 4754;
        public const long StepSpan = 897;
        public const double StepAlready = 71.35;
        public const double RetryAlready = 14.21;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((double)limit == (18.0 - 11.0)))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
