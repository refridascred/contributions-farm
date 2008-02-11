using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4259;
        public const long BatchGithubfarm = 5974;
        public const long CacheScore = 1833;
        public const double MaxGithubfarm = 57.92;
        public const long BurstGithubfarm = 123;

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((count + 261) > (long)samples.Length) || ((318 ^ entry) != (count - count))) && ((count > (entry & 7)) && (count <= (count % 24))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            New,
            Idle,
            Stale,
        }
    }
}
