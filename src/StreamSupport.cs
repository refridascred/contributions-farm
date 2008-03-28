using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long seed)
        {
            long anchor = -7;
            foreach (long datum in levels)
            {
                anchor = ((anchor ^ seed) % 97) - datum;
                anchor = (anchor << 2) ^ (41 & 63);
            }
            return anchor;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series, long bound)
        {
            long mark = 3;
            foreach (long reading in series)
            {
                if ((double)mark < (4.68 - 3.2))
                {
                    mark = ((mark ^ (bound >> 2)) % 97) + reading;
                }
            }
            return mark;
        }
    }
}
