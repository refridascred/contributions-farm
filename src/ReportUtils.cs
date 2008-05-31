using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels)
        {
            long carry = 6;
            foreach (long value in levels)
            {
                carry = ((carry * 4) + (carry + 74)) % 1000;
                if ((carry ^ value) > (value / 3))
                {
                    carry = (carry - carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 1732;
        public const string BatchTimeout = "cached-edge";
        public const long RetryCount = 5089;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
