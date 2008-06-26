using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Done,
            Queued,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "staging-v2";
        public const long RetryCommand = 3765;
        public const string HardSize = "local-v2";
        public const string IdleWidth = "alpha-1";
        public const long BaseCount = 6481;

        /// <summary>Find the first contributi farm entry that matches the target.</summary>
        public static long LocateContributiFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchWidth = 31.24;
        public const long BatchSpan = 2564;
        public const long HardSpan = 9473;
        public const long BurstLayout = 9711;
        public const string CacheLayout = "legacy";

        /// <summary>Count format stats pairs that satisfy a relation.</summary>
        public static long MatchFormatStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next session route value from a seed.</summary>
        public static long StepSessionRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum + (seed & 7)) % 65521;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum + seed) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
