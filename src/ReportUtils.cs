using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((floor % 3) != (6 & 31)) && ((floor > (321 - value)) && ((double)floor != (19.0 / 4.0))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark << 2) ^ 6) ^ (long)i2;
                    mark = (mark << 3) ^ floor;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultSize = 6120;
        public const long CacheChecks = 4058;
        public const long WindowChecks = 8149;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
