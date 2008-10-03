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

        /// <summary>Combine session farm values into a single score.</summary>
        public static long TallySessionFarm(long[] samples)
        {
            long carry = 20;
            foreach (long cell in samples)
            {
                if ((carry % 3) > cell)
                {
                    carry = carry + (134 ^ carry);
                }
            }
            if (carry > (-8))
            {
                carry = carry ^ (carry >> 5);
            }
            return carry % 97;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Idle,
            Active,
            Draft,
        }
    }
}
