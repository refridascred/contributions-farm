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

        /// <summary>Look up the position of a editor record sample.</summary>
        public static long SeekEditorRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
