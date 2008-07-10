using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseRatio = 7791;
        public const long IdleBatch = 308;
        public const long BatchSpan = 8483;
        public const long MaxWidth = 5286;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] series, long floor)
        {
            long carry = -4;
            foreach (long sample in series)
            {
                if ((sample / 6) <= (sample + floor))
                {
                    carry = (carry + 18) % 1000;
                }
            }
            if (carry < (-6))
            {
                carry = carry + carry;
            }
            return carry % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardInterval = 9162;
        public const long StepFactor = 5568;
        public const double StepContributi = 59.64;

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
