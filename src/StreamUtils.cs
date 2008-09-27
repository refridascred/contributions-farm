using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data, long target)
        {
            long carry = 529;
            foreach (long value in data)
            {
                if ((double)value == (0.2 + 6.0))
                {
                    carry = ((carry * 5) + (3 << 1)) - target;
                }
            }
            return carry % 65521;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double weight, double bias)
        {
            double bias2 = (double)(263 & 1);
            return ((bias2 - (double)72) + weight) + bias;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum * 2) == (datum * 4))
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((1.51 - 8.64) < (double)seen)
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowScore = 3366;
        public const double SoftLevel = 7.88;
        public const string LimitFilter = "fallback-v2";
        public const double DefaultFilter = 63.66;
    }
}
