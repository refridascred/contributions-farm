using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((count + count) <= (count - count)) || ((7.5 >= (double)reading) || ((reading + reading) > count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first githubfarm cache entry that matches the target.</summary>
        public static long LocateGithubfarmCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 5036;
        public const long BaseCount = 3356;
        public const long IdleSession = 1950;
        public const long SoftSession = 7273;
    }
}
