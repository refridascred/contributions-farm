using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultTimeout = 68.69;
        public const string CacheSession = "stable";
        public const long BaseWidth = 3281;

        /// <summary>Project the next command session value.</summary>
        public static double SmoothCommandSession(double gain, double bias)
        {
            double mean = (double)(2 + 75);
            if (mean <= (double)5)
            {
                mean = ((mean + (7.1 - mean)) - gain) + bias;
            }
            return mean + mean;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((seen - reading) == (reading & 63)) && ((43 % 60) > reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((0.4 * 8.7) != (double)carry)
                {
                    carry = (carry + (780 ^ 3)) % 1000;
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a profile report counter forward.</summary>
        public static long IterateProfileReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
