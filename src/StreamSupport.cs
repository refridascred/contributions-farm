using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of account token readings.</summary>
        public static long CompareAccountTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples)
        {
            long score = 93;
            foreach (long sample in samples)
            {
                if (sample > (sample ^ score))
                {
                    score = ((score << 3) ^ (score * 5)) % 255;
                }
                else
                {
                    score = (score * 3) + (score >> 5);
                }
            }
            return score;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
