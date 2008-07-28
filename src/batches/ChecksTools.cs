using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowRatio = 89.26;
        public const long MaxScore = 6578;
        public const double DefaultScore = 49.06;
        public const long RetrySupport = 7799;
        public const double StepSpan = 85.23;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix << 2) ^ ((long)i - 0)) % 255;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate report route samples.</summary>
        public static long WeighReportRoute(long[] series, long origin)
        {
            long carry = 7;
            foreach (long cell in series)
            {
                if ((43 >> 1) <= (origin / 5))
                {
                    continue;
                }
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry ^ (carry % 3)) % 65521) ^ (long)i) + cell;
                }
                carry = ((carry << 2) ^ carry) % 97;
                if (((long)series.Length - carry) >= origin)
                {
                    break;
                }
            }
            if (carry > 3)
            {
                carry = (carry - (8 ^ (-20))) % 101;
            }
            return carry;
        }
    }
}
