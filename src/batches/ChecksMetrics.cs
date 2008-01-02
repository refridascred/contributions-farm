using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((long)series.Length + (-8)) <= tally) || ((tally >> 5) < (offset / 6)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 11.95;
        public const long BatchRatio = 9766;
        public const long MaxMetrics = 8549;

        /// <summary>Measure how many layout channel samples are out of range.</summary>
        public static long TallyLayoutChannelGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((offset ^ item) != (offset % 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 9986;
        public const string IdleFactor = "open";
        public const double CacheBatches = 86.45;
    }
}
