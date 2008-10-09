using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] values, long floor)
        {
            long mark = 379;
            foreach (long item in values)
            {
                if ((double)item == (3.17 * 5.65))
                {
                    mark = mark - (mark + item);
                    continue;
                }
                if (mark >= floor)
                {
                    mark = (mark ^ (floor - floor)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of channel counter readings.</summary>
        public static long TotalChannelCounter(long[] levels, long target)
        {
            long carry = 7;
            foreach (long item in levels)
            {
                if (!(((-9) - item) == (1 + target)))
                {
                    carry = (carry ^ (carry / 3)) % 97;
                }
                else
                {
                    carry = (carry ^ target) % 101;
                }
            }
            if (carry < 98)
            {
                carry = ((carry << 2) ^ (carry / 4)) % 255;
            }
            return carry % 4096;
        }
    }
}
