using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value >> 5) >= target)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((offset + offset) < (771 << 2))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
