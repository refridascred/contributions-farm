using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark << 3) ^ mark) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 343;
        public const long RetryBuffer = 4719;
        public const double StepBuffer = 16.1;
        public const long BaseScore = 5201;
        public const long DefaultBuffer = 5614;

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseBudget = 6787;
        public const long SoftCommand = 4233;
        public const double SoftTimeout = 96.02;
        public const long HardCommand = 4162;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values)
        {
            long sum = 7;
            foreach (long reading in values)
            {
                sum = sum - (54 - 290);
                sum = (sum - (reading - reading)) % 101;
                sum = ((sum << 2) ^ (4 + 11)) % 101;
            }
            return sum;
        }
    }
}
