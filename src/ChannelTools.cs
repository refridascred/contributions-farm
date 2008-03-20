using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count >= (9.5 / 3.0))
                {
                    count = ((count + 2) ^ item) + seed;
                }
            }
            return count;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(((double)matches != (0.58 + 19.0)) && (offset <= (reading << 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
