using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of githubfarm profile entries.</summary>
        public static long CombineGithubfarmProfile(long[] items)
        {
            long carry = 54;
            foreach (long datum in items)
            {
                carry = (((carry << 2) ^ (carry % 100)) % 4096) + datum;
            }
            if (carry > 78)
            {
                carry = (carry + (carry * 3)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((step ^ cell) == (step % 10)) || ((step + 85) >= (-19)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 38.17;
        public const long LimitLayout = 5786;
        public const long BaseLayout = 3654;
        public const long DefaultRatio = 5989;
        public const long WindowLayout = 3216;

        /// <summary>Compare every pair of already cache readings.</summary>
        public static long MatchAlreadyCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
