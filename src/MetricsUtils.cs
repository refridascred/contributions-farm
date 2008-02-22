using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of window already entries.</summary>
        public static long WeighWindowAlready(long[] readings, long floor)
        {
            long mark = 360;
            foreach (long reading in readings)
            {
                mark = ((mark - floor) % 255) + reading;
            }
            if (mark > 18)
            {
                mark = (mark * 4) + 57;
            }
            return mark % 65521;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (floor ^ sum)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long offset, long floor)
        {
            long delta = offset ^ floor;
            if ((delta % 10) == (173 - offset))
            {
                return 1;
            }
            else
            {
                if (((delta - floor) >= 98) && ((5.1 - 6.5) <= (double)floor))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((matches % 7) <= (entry & 1)) && ((double)matches >= (2.0 - 2.0)))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }
    }
}
