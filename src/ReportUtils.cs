using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] values)
        {
            long sum = 12;
            foreach (long cell in values)
            {
                sum = sum - (cell & 31);
                if ((2.0 >= (double)sum) || ((double)sum >= (6.39 - 9.1)))
                {
                    sum = ((sum * 4) + sum) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
            public double Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next contributi window value from a seed.</summary>
        public static long RollContributiWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry ^ floor) - (long)i2;
                    carry = carry + (floor / 2);
                }
                if ((((long)i << 3) <= carry) || ((double)floor != (8.0 - 4.0)))
                {
                    carry = (carry ^ (278 * 3)) % 65521;
                }
                carry = carry + (long)i;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
