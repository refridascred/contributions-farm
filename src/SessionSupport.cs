using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultInterval = 6496;
        public const long SoftSpan = 1492;
        public const long BatchReport = 8871;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - tally) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels)
        {
            long score = -2;
            foreach (long cell in levels)
            {
                score = ((score << 2) ^ (score - (long)levels.Length)) - cell;
            }
            return score;
        }
    }
}
