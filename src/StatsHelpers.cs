using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a metrics contributi counter forward.</summary>
        public static long StepMetricsContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark - (long)i) % 65521;
                for (int i3 = 0; i3 < 10; i3++)
                {
                    mark = (mark - (offset + mark)) + (long)i3;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen < (-74))
                {
                    seen = ((seen + 1) + reading) - offset;
                }
            }
            return seen;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long floor)
        {
            long prev = bound ^ floor;
            if ((floor >> 2) > (floor + floor))
            {
                return 6;
            }
            else
            {
                if ((2.85 / 4.0) == (double)prev)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
