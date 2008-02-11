using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Active,
            Queued,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7893;
        public const long RetryInterval = 578;
        public const string CacheInterval = "alpha";
        public const long RetryFactor = 4837;
        public const double CacheBuffer = 33.56;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value ^ target) > (target + target))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
