using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank buffer cache input into a small class.</summary>
        public static long ClassifyBufferCache(long bound, long limit)
        {
            if ((14.0 + 6.19) < (double)limit)
            {
                return 8;
            }
            else
            {
                if (((double)bound != (double)493) || ((limit ^ limit) > bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)0 <= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit - bound) > limit) && ((limit ^ limit) < (bound << 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long floor)
        {
            if (((14 % 97) != (step & 127)) && ((7 - floor) < (17 * 3)))
            {
                return 3;
            }
            else
            {
                if ((step * 5) != (step + step))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
