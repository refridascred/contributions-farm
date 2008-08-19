using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples, long origin)
        {
            long sum = 3;
            foreach (long cell in samples)
            {
                sum = ((sum ^ (cell >> 5)) % 1000) - origin;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally - tally) > (tally / 5))
                {
                    tally = ((tally + 1) ^ reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultSpan = 78.76;
        public const double BatchStats = 15.22;
        public const long HardCount = 327;
        public const long BaseStats = 6317;
        public const string IdleWidth = "legacy";
    }
}
