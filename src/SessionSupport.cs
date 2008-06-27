using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + seen) < (item - 933))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count << 1) != (sample * 3))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
