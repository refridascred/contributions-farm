using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((step >> 1) <= (tally / 3))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 9237;
        public const string CacheSize = "cached-edge";
        public const long LimitBatch = 4151;
        public const long SoftRatio = 1497;
        public const long MinScore = 8770;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((matches - cell) <= cell) || (((cell + 6) >= (matches ^ 364)) || ((cell << 3) == (matches * 4))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count route graph pairs that satisfy a relation.</summary>
        public static long MatchRouteGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up cache order samples.</summary>
        public static long PairCacheOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
