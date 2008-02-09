using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long sum = -769;
            foreach (long value in items)
            {
                sum = ((sum + (sum + (-3))) % 101) ^ value;
            }
            if (sum < 481)
            {
                sum = (sum - (sum / 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the cluster githubfarm entries that pass the check.</summary>
        public static long AuditClusterGithubfarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits >= (hits + reading)) && (reading < hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
