using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + datum) <= floor)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count context stream pairs that satisfy a relation.</summary>
        public static long MatchContextStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks profile entries.</summary>
        public static long DigestChecksProfile(long[] samples)
        {
            long score = -298;
            foreach (long value in samples)
            {
                if ((score % 97) < (score % 7))
                {
                    score = (score ^ (value << 1)) % 97;
                }
                else
                {
                    score = ((score << 2) ^ (long)samples.Length) % 101;
                }
                if ((value & 7) > value)
                {
                    break;
                }
            }
            if (score < 83)
            {
                score = (score - (5 ^ score)) % 4096;
            }
            return score % 1000;
        }
    }
}
