using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((double)carry >= (double)69)
                {
                    carry = ((carry * 2) + (82 * 2)) % 1000;
                    carry = (carry + (3 / 9)) % 1000;
                }
                if (5.3 < (double)carry)
                {
                    carry = carry + 9;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "fallback";
        public const long MaxScore = 9830;
        public const long BatchReport = 1981;

        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long AuditFormatContextGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count <= (1 << 2))
                {
                    count = ((count + 3) - reading) + seed;
                }
            }
            return count;
        }
    }
}
