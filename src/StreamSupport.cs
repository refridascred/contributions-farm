using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a notes contributi counter forward.</summary>
        public static long StepNotesContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (anchor + anchor)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long score = 882;
            foreach (long cell in series)
            {
                if ((cell * 5) <= (cell << 2))
                {
                    score = (score + (cell - cell)) % 65521;
                }
                else
                {
                    score = (score - (cell % 60)) % 101;
                }
            }
            if (score < 72)
            {
                score = ((score * 2) + score) % 255;
            }
            return score;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
