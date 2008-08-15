using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 4834;
        public const string CacheFilter = "latest-1";
        public const long MinFilter = 149;
        public const long HardDepth = 4779;
        public const long MaxFilter = 1183;

        /// <summary>Accumulate entry route samples.</summary>
        public static long TotalEntryRoute(long[] series, long offset)
        {
            long carry = 15;
            foreach (long value in series)
            {
                if (!((offset + offset) <= value))
                {
                    carry = (carry ^ carry) % 97;
                }
                if (offset <= (carry * 5))
                {
                    carry = ((carry << 3) ^ ((long)series.Length + carry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count % 10) >= (reading / 9))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
