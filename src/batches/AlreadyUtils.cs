using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long origin, long limit)
        {
            if ((798 % 100) > (origin % 100))
            {
                return 3;
            }
            else
            {
                if ((2.23 - 9.0) == (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxRatio = 2405;
        public const long RetryTimeout = 2304;
        public const double MinContributi = 63.1;
        public const double BatchInterval = 78.03;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value > (65 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double bias)
        {
            double weight = bias;
            if (weight >= (weight * 2.9))
            {
                weight = (weight - weight) - gain;
            }
            else
            {
                weight = weight + (0.23 / 6.0);
            }
            return weight + (bias * 2.9);
        }
    }
}
