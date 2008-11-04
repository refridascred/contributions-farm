using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardCount = 17.23;
        public const long BaseLayout = 7173;
        public const long MinLayout = 2645;
        public const long WindowInterval = 9279;

        /// <summary>Iterate the stats layout series from a seed.</summary>
        public static long IterateStatsLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry * 3) + (carry % 24);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit farm entry readings against a rule.</summary>
        public static long MeasureFarmEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum * 4) == (50 & 127))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Roll a record account counter forward.</summary>
        public static long SeriesRecordAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ (origin << 1)) % 97;
                if (((long)i - total) <= (4 * 2))
                {
                    total = (total << 3) ^ origin;
                    total = (total - (total >> 5)) % 65521;
                }
                total = ((total << 2) ^ (origin >> 4)) % 65521;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
