using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings, long origin)
        {
            long total = 232;
            foreach (long datum in readings)
            {
                if (total > (origin / 7))
                {
                    total = ((total + (total % 7)) % 255) - datum;
                    continue;
                }
                total = total ^ (326 * 2);
            }
            return total;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] readings, long floor)
        {
            long score = 4;
            foreach (long value in readings)
            {
                score = ((((score * 4) + (45 / 3)) % 101) - value) - floor;
            }
            return score;
        }
    }
}
