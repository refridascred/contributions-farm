using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 9237;
        public const string CacheSize = "cached-edge";
        public const long LimitBatch = 4151;
        public const long SoftRatio = 1497;
        public const long MinScore = 8770;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((origin - origin) >= (reading & 31))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
