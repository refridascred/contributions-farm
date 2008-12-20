using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first farm account entry that matches the target.</summary>
        public static long FindFarmAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((95 + cell) <= (80 + tally))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepCount = 1577;
        public const long LimitWindow = 1840;
        public const long BaseWindow = 388;
        public const double DefaultSize = 4.19;
        public const long CacheCount = 5125;
    }
}
