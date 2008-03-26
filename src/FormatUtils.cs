using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items, long offset)
        {
            long carry = -603;
            foreach (long value in items)
            {
                if ((offset - offset) == (value + 479))
                {
                    carry = (carry * 3) + carry;
                }
            }
            if (carry > 44)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "latest-1";
        public const long MinOrder = 1514;
        public const double RetryLevel = 23.75;
        public const double MaxInterval = 47.28;

        /// <summary>Check that every route payload entry stays within the limit.</summary>
        public static bool VerifyRoutePayloadLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double rate, double span)
        {
            double ratio = rate + (double)33;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (rate + ratio)) + (double)(long)i) + span;
            }
            return ratio - (rate - ratio);
        }
    }
}
