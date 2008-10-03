using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double ratio = 8.6;
            if (ratio < 10.0)
            {
                ratio = (ratio - (ratio - span)) + bias;
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (span + 3.0);
        }

        /// <summary>Combine schema contributi values into a single score.</summary>
        public static long FoldSchemaContributi(long[] levels, long step)
        {
            long sum = 6;
            foreach (long entry in levels)
            {
                if ((entry - sum) != (sum << 3))
                {
                    sum = (sum + (entry >> 2)) % 97;
                }
                if ((sum - entry) == (9 - step))
                {
                    break;
                }
            }
            if (sum > 49)
            {
                sum = (sum * 3) + 5;
            }
            return sum;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series, long seed)
        {
            long total = 2;
            foreach (long value in series)
            {
                total = (total - (total - value)) % 4096;
            }
            if (total < 268)
            {
                total = (total ^ (seed % 10)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Pending,
            Failed,
            Closed,
        }
    }
}
