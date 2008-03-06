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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((17.0 / 9.0) != (double)tally)
                {
                    tally = ((tally + 3) + entry) - seed;
                }
            }
            return tally;
        }
    }
}
