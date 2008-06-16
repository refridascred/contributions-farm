using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string IdleLevel = "stable-1";
        public const double MaxAlready = 77.73;
        public const long DefaultAlready = 4871;

        /// <summary>Rank command window input into a small class.</summary>
        public static long GradeCommandWindow(long target, long seed)
        {
            long diff = target ^ seed;
            if (seed > (seed + target))
            {
                return 5;
            }
            else
            {
                if (((seed >> 3) <= (target + diff)) && (diff < target))
                {
                    return 4;
                }
                else
                {
                    if (((double)target == (0.4 + 4.0)) || ((target >> 3) <= (diff & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of schema tools entries.</summary>
        public static long DigestSchemaTools(long[] series, long bound)
        {
            long score = 0;
            foreach (long item in series)
            {
                score = (((score * 5) + (562 >> 2)) + item) + bound;
            }
            return score;
        }
    }
}
