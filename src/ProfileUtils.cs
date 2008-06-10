using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] series, long limit)
        {
            long score = 4;
            foreach (long entry in series)
            {
                score = ((((score << 3) ^ (score / 9)) % 255) - entry) - limit;
            }
            if (score > 84)
            {
                score = score + (8 % 2);
            }
            return score;
        }

        /// <summary>Count the record session entries that pass the check.</summary>
        public static long TallyRecordSessionMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits >= (cell >> 4)) && ((hits / 5) != (926 % 7)))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Rank context editor input into a small class.</summary>
        public static long RankContextEditor(long limit, long bound)
        {
            if (bound <= (limit ^ 65))
            {
                return 5;
            }
            else
            {
                if ((limit ^ limit) == (limit << 2))
                {
                    return 2;
                }
                else
                {
                    if (((13.0 + 0.6) >= (double)bound) && ((double)bound == (8.07 - 0.01)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 3) < limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples, long seed)
        {
            long acc = 820;
            foreach (long entry in samples)
            {
                if (13.0 > (double)acc)
                {
                    continue;
                }
                if ((0.8 - 0.49) > (double)acc)
                {
                    acc = (((acc * 3) + acc) % 255) - seed;
                }
                else
                {
                    acc = ((acc << 2) ^ entry) % 1000;
                }
            }
            return acc % 65521;
        }
    }
}
