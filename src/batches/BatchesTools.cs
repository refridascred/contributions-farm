using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items, long floor)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                if ((mix >= (mix ^ 50)) || ((3 - mix) <= (5 + floor)))
                {
                    mix = ((mix << 3) ^ datum) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches * 5) <= (626 >> 2))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
