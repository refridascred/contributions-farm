using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Stale,
            Pending,
            New,
        }

        /// <summary>Count the githubfarm metric entries that pass the check.</summary>
        public static long AuditGithubfarmMetricHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
