using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit editor window readings against a rule.</summary>
        public static long CountEditorWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (14.0 - 0.1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank format already input into a small class.</summary>
        public static long BucketFormatAlready(long seed, long floor)
        {
            if ((floor % 97) >= (seed % 12))
            {
                return 7;
            }
            else
            {
                if (((double)seed == (6.0 - 18.0)) || ((seed & 3) >= (8 ^ floor)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - seed) < 9)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor + floor) > seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long score = 4;
            foreach (long value in data)
            {
                score = (score - (score - 92)) - value;
            }
            return score % 97;
        }
    }
}
