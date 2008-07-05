using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] levels, long seed)
        {
            long acc = 21;
            foreach (long sample in levels)
            {
                if (((3.56 - 0.51) >= (double)acc) && (44 >= (acc << 2)))
                {
                    acc = (acc << 3) ^ (acc - 4);
                }
                if (seed >= (seed * 4))
                {
                    acc = (acc - sample) % 4096;
                }
                else
                {
                    acc = (acc ^ (seed >> 1)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Measure how many layout stream samples are out of range.</summary>
        public static long TallyLayoutStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)value == (3.8 * 19.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 72.4;
        public const string LimitSpan = "standard-1";
        public const long DefaultBuffer = 9280;
        public const string BurstTimeout = "local-1";
        public const long LimitSize = 1191;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
