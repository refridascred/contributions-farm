using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] items, long step)
        {
            long score = 6;
            foreach (long datum in items)
            {
                if (!((step * 5) <= score))
                {
                    score = ((score << 3) ^ 3) % 255;
                }
                score = (score - (datum % 16)) % 255;
            }
            return score % 97;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (0.06 <= (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
