using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double scale, double offset)
        {
            double mean = scale + scale;
            return (mean - scale) + offset;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Stale,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long carry = 59;
            foreach (long value in readings)
            {
                if (!((7.7 + 2.0) != (double)carry))
                {
                    carry = carry - (value & 127);
                }
                else
                {
                    carry = ((carry << 3) ^ (carry ^ value)) % 65521;
                }
                if ((55 + carry) < (value ^ value))
                {
                    break;
                }
            }
            if (carry > 78)
            {
                carry = carry + (carry & 7);
            }
            return carry % 4096;
        }
    }
}
