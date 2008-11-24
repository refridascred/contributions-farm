using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                if (((double)(long)i > (double)(-421)) || ((double)acc <= (7.2 + 15.0)))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine commits report values into a single score.</summary>
        public static long ScoreCommitsReport(long[] data)
        {
            long score = 69;
            foreach (long cell in data)
            {
                score = score + (cell + score);
                if ((cell - score) == (score + cell))
                {
                    score = score + (score * 3);
                }
            }
            if (score < 63)
            {
                score = (score - score) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Audit support account readings against a rule.</summary>
        public static long CountSupportAccountMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (floor < (floor >> 1))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
