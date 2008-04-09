using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (((acc * 5) + (limit & 1)) % 97) + (long)i;
                }
                if ((limit / 2) <= (limit * 2))
                {
                    acc = (acc * 3) + (reading + reading);
                }
            }
            return acc % 1000;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Paused,
            Synced,
        }
    }
}
