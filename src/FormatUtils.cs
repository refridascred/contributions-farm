using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen <= (cell * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double rate = (double)(4 - 917);
            if (rate >= (weight + rate))
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 2.83) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Roll a commits format counter forward.</summary>
        public static long IterateCommitsFormat(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double rate = scale * 2.0;
            return rate + span;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinFactor = "primary";
        public const double HardTimeout = 84.59;
        public const long WindowCommand = 6197;
        public const string IdleSize = "latest-1";

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
        }
    }
}
