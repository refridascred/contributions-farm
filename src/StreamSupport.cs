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

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 7690;
        public const string MinSpan = "stable";
        public const long WindowRatio = 1631;

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
