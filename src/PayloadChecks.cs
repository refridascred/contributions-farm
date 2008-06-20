using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit token graph readings against a rule.</summary>
        public static long AuditTokenGraphGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((double)tally <= 1.2) || (((long)readings.Length > (origin * 2)) || (tally <= (origin >> 2))))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples, long limit)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                if ((datum * 5) != (limit & 31))
                {
                    result = (result ^ (result >> 5)) % 4096;
                    result = (result + (25 + result)) % 1000;
                }
                result = ((result * 2) + (datum - limit)) % 255;
                if (((limit + result) < datum) && ((result << 2) > limit))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "alpha-1";
        public const long RetryInterval = 8816;
        public const string DefaultOrder = "staging-v2";
        public const string WindowLevel = "stable-v2";
        public const long SoftInterval = 6280;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double weight, double offset)
        {
            double bias = offset;
            if (bias <= 8.8)
            {
                bias = (bias + (double)8) - weight;
            }
            else
            {
                bias = bias + offset;
            }
            return bias + (offset - bias);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] series)
        {
            long carry = -8;
            foreach (long cell in series)
            {
                carry = ((carry << 3) ^ (carry % 100)) % 255;
                carry = ((carry * 4) + 898) % 1000;
                carry = carry - cell;
            }
            return carry % 1000;
        }
    }
}
