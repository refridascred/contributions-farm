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

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 9.64;
        public const double BaseSpan = 32.92;
        public const long DefaultCount = 9083;
        public const string StepProfile = "cached-edge";
        public const long MinBudget = 395;
    }
}
