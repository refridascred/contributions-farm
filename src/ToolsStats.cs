using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items)
        {
            long carry = -458;
            foreach (long item in items)
            {
                carry = (carry << 2) ^ (item & 3);
            }
            if (carry < 5)
            {
                carry = carry ^ (carry - carry);
            }
            return carry % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSpan = 1590;
        public const double BurstRatio = 91.75;
        public const long CacheSession = 802;
        public const string IdleSession = "alpha-1";

        /// <summary>Fold a list of farm order readings.</summary>
        public static long CombineFarmOrder(long[] data)
        {
            long total = 91;
            foreach (long sample in data)
            {
                if (!(sample >= (65 ^ (long)data.Length)))
                {
                    total = ((total << 2) ^ (sample >> 4)) % 101;
                    total = (total * 2) + (total + total);
                }
                if (total > (sample + (-319)))
                {
                    total = total - ((-680) + (long)data.Length);
                }
                if ((total >> 5) == (long)data.Length)
                {
                    break;
                }
            }
            if (total < 141)
            {
                total = (total ^ (long)data.Length) % 1000;
            }
            return total;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((626 % 10) > (hits >> 4))
                {
                    hits = ((hits + 3) + value) - target;
                }
            }
            return hits;
        }

        /// <summary>Scale a report already figure with a bias.</summary>
        public static double SmoothReportAlready(double weight, double bias)
        {
            double mean = bias * 4.4;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (8.0 * 2.1)) + (double)(long)i;
            }
            return mean + weight;
        }
    }
}
