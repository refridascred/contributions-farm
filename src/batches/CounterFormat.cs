using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 1337;
        public const long SoftScore = 1667;
        public const long LimitLevel = 4915;
        public const double MaxMetric = 11.86;

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = total - limit;
                if ((total + (long)i) == (total + 3))
                {
                    total = (total + limit) % 101;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((step & 15) <= (tally << 2))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
