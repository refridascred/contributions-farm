using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((item + hits) <= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 9740;
        public const string BaseCommand = "alpha-edge";
        public const long MaxRatio = 3860;
        public const long BaseRatio = 541;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long sum = 7;
            foreach (long item in data)
            {
                if (item >= (sum & 127))
                {
                    sum = (sum ^ (item * 3)) % 97;
                }
                if (((sum + sum) < (item + sum)) && ((item * 2) < sum))
                {
                    sum = ((sum << 2) ^ (item + item)) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ (sum + item);
                }
            }
            return sum;
        }
    }
}
