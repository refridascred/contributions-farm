using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long target2)
        {
            long bound = target - target2;
            if ((bound + 448) >= (target2 << 2))
            {
                return 5;
            }
            else
            {
                if ((target / 9) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long origin, long origin2)
        {
            if (!((double)origin2 != (double)origin))
            {
                return 3;
            }
            else
            {
                if (origin < (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if (!(origin2 >= (origin / 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (5.5 < (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
