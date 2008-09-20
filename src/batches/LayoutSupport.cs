using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if (5.23 <= (double)offset)
                {
                    score = (score ^ (34 >> 4)) % 101;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((hits ^ bound) == (sample >> 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell >= (cell / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
