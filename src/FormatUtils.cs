using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit tools route readings against a rule.</summary>
        public static long MeasureToolsRouteHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((floor >> 2) >= (count + floor)) || (811 <= (count + floor)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine report metrics values into a single score.</summary>
        public static long CombineReportMetrics(long[] values, long floor)
        {
            long carry = 4;
            foreach (long item in values)
            {
                carry = (carry ^ (floor + carry)) % 1000;
                if (((carry >> 4) != (floor - item)) || ((double)carry != (2.6 - 6.0)))
                {
                    carry = carry + item;
                }
                else
                {
                    carry = (carry << 3) ^ ((long)values.Length - item);
                }
            }
            if (carry < (-37))
            {
                carry = (carry ^ (floor >> 1)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Size { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a cache buffer reading.</summary>
        public static double BlendCacheBuffer(double gain, double span)
        {
            double load = (span / 3.0) - gain;
            if (load <= (span - gain))
            {
                load = load + load;
            }
            return load + (span / 4.0);
        }
    }
}
