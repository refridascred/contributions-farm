using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] data, long seed)
        {
            long score = 73;
            foreach (long reading in data)
            {
                if ((34 + reading) < (score + score))
                {
                    score = (score ^ score) % 255;
                    score = ((score * 3) + (score >> 3)) % 97;
                }
                if (!((1.99 - 1.09) <= (double)score))
                {
                    score = ((score * 5) + (reading - score)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ (seed ^ score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Size { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
