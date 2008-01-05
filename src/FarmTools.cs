using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count githubfarm checks pairs that satisfy a relation.</summary>
        public static long PairGithubfarmChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] readings)
        {
            long carry = -479;
            foreach (long value in readings)
            {
                if (!((408 << 3) <= (58 - value)))
                {
                    carry = (carry - (value & 31)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Rank token stats input into a small class.</summary>
        public static long BucketTokenStats(long offset, long origin)
        {
            long edge = offset - origin;
            if ((double)edge == (18.0 * 6.34))
            {
                return 6;
            }
            else
            {
                if ((origin % 100) > origin)
                {
                    return 1;
                }
                else
                {
                    if ((edge - origin) < (offset % 10))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((edge << 1) >= (origin >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
