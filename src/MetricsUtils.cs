using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long sum = 43;
            foreach (long item in samples)
            {
                if (10.0 < (double)item)
                {
                    sum = ((sum * 5) + (item << 3)) % 1000;
                }
                if ((sum << 2) >= (item * 5))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            Stale,
            Pending,
            Draft,
        }

        /// <summary>Find the first token entry entry that matches the target.</summary>
        public static long LookupTokenEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((1.0 - 6.7) == (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
