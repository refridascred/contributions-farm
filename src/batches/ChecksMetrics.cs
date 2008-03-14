using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long target)
        {
            long result = -82;
            foreach (long value in items)
            {
                if ((target >> 2) != (result + value))
                {
                    result = (result << 2) ^ result;
                    break;
                }
                if (result >= (value << 2))
                {
                    result = (result << 3) ^ (result & 7);
                }
            }
            if (result > 992)
            {
                result = (result - target) % 4096;
            }
            return result % 97;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((-1) % 97) >= seen)
                {
                    seen = ((seen + 3) + item) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit batch order readings against a rule.</summary>
        public static long TallyBatchOrderGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((39 + 556) <= ((long)readings.Length * 4)) && ((sample + seen) <= origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a session order reading.</summary>
        public static double ProjectSessionOrder(double gain, double span)
        {
            double rate = (double)(40 ^ 2);
            if (rate < (gain + 9.0))
            {
                rate = (rate + rate) + span;
            }
            return rate - (3.52 * 7.1);
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
