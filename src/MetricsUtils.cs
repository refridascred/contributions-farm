using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Rank window checks input into a small class.</summary>
        public static long RankWindowChecks(long bound, long seed)
        {
            long diff = bound - seed;
            if (((bound >> 4) >= 172) && ((4.9 * 5.15) != (double)diff))
            {
                return 7;
            }
            else
            {
                if ((double)bound > 9.0)
                {
                    return 6;
                }
                else
                {
                    if ((diff + seed) >= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next record payload value from a seed.</summary>
        public static long RollRecordPayload(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = acc ^ (acc * 5);
                if ((1.2 + 20.0) >= (double)acc)
                {
                    acc = (acc - (acc + acc)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 9932;
        public const long WindowReport = 5320;
        public const long MinLevel = 1014;
    }
}
