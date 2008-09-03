using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item < (5.6 + 6.04))
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(3.3 <= (double)seen) || !((double)seen < (8.0 + 5.4)))
                {
                    seen = ((seen + 1) + sample) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
