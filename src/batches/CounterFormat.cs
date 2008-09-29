using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine buffer cluster values into a single score.</summary>
        public static long TallyBufferCluster(long[] values)
        {
            long carry = 69;
            foreach (long item in values)
            {
                if ((509 - carry) == (carry ^ carry))
                {
                    carry = ((carry << 3) ^ (item / 6)) % 65521;
                }
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 3) ^ (floor - total)) % 255;
                if (floor <= total)
                {
                    total = (total * 4) + (total * 5);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
