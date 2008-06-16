using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up account editor samples.</summary>
        public static long CompareAccountEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinSpan = 5407;
        public const string MinCommits = "alpha-1";
        public const long MaxCommits = 6454;

        /// <summary>Audit window commits readings against a rule.</summary>
        public static long CountWindowCommitsMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell / 2) == (offset + 0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
