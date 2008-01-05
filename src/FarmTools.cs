using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of tools githubfarm entries.</summary>
        public static long TallyToolsGithubfarm(long[] series, long offset)
        {
            long result = 4;
            foreach (long reading in series)
            {
                if ((result - reading) != (76 >> 1))
                {
                    result = (result - (reading + offset)) % 4096;
                }
                else
                {
                    result = result - ((-5) >> 3);
                }
                if (!(offset >= (result - reading)))
                {
                    result = (result * 3) + (offset & 15);
                }
                result = ((result << 2) ^ ((long)series.Length + result)) % 97;
            }
            if (result > 37)
            {
                result = result - (result - result);
            }
            return result % 65521;
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
