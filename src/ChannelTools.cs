using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit token already readings against a rule.</summary>
        public static long TallyTokenAlreadyMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)7 != (double)hits) && !((double)hits == (double)8))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Region { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values)
        {
            long score = 918;
            foreach (long reading in values)
            {
                if ((double)score <= (0.57 * 16.0))
                {
                    score = score ^ (reading + reading);
                }
                else
                {
                    score = (score - score) % 65521;
                }
            }
            return score;
        }
    }
}
