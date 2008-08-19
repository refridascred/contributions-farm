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

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long bound, long target)
        {
            long offset = bound + target;
            if (761 <= (offset ^ offset))
            {
                return 7;
            }
            else
            {
                if (((double)bound >= (0.8 + 3.0)) && ((target << 1) == (target - bound)))
                {
                    return 0;
                }
                else
                {
                    if (5.84 < (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((15.0 / 5.0) == (double)target) && ((bound - target) >= bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
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
