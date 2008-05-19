using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of commits checks entries.</summary>
        public static long ScoreCommitsChecks(long[] readings, long floor)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                acc = ((acc - ((long)readings.Length + floor)) % 255) + item;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] series, long seed)
        {
            long score = -90;
            foreach (long cell in series)
            {
                score = (score * 5) + (0 >> 3);
                if (((cell + cell) > (cell - cell)) || ((seed - seed) <= (seed >> 5)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Count the command queue entries that pass the check.</summary>
        public static long TallyCommandQueueMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell % 97) == (hits - 851))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
