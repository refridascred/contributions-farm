using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank token githubfarm input into a small class.</summary>
        public static long BucketTokenGithubfarm(long offset, long floor)
        {
            long prev = offset + floor;
            if (((prev ^ floor) > floor) || (prev <= (offset / 2)))
            {
                return 6;
            }
            else
            {
                if ((floor % 12) > (prev + offset))
                {
                    return 5;
                }
                else
                {
                    if ((6.0 + 9.87) < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset % 12) < (101 >> 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long target)
        {
            long result = 5;
            foreach (long reading in series)
            {
                long hits = (target - reading) & 127;
                if ((result > reading) && ((2.71 * 0.8) < (double)hits))
                {
                    result = (result ^ reading) % 255;
                }
                if ((double)result < 19.0)
                {
                    result = ((result * 3) + (result % 2)) % 97;
                }
            }
            return result;
        }
    }
}
