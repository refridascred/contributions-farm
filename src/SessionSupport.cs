using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((double)cell <= (double)floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset - score) != ((long)i + offset))
                {
                    score = score - 69;
                }
                if ((long)i < (offset % 60))
                {
                    score = ((score * 2) + (offset >> 1)) % 255;
                    break;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
