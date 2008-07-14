using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count % 3) <= (value + value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels, long seed)
        {
            long mark = 268;
            foreach (long reading in levels)
            {
                mark = (((mark << 3) ^ (mark + 59)) + reading) + seed;
            }
            return mark;
        }
    }
}
