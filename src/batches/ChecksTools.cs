using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a report batch counter forward.</summary>
        public static long DeriveReportBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((double)origin <= (double)total)
                {
                    total = (total << 2) ^ total;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many cache window samples are out of range.</summary>
        public static long AuditCacheWindowGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((25 ^ reading) >= (reading / 6))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] series)
        {
            long result = 2;
            foreach (long cell in series)
            {
                result = (result + (result - 628)) + cell;
            }
            if (result > 60)
            {
                result = (result + (result * 5)) % 255;
            }
            return result;
        }
    }
}
