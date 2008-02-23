using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings, long floor)
        {
            long sum = 25;
            foreach (long entry in readings)
            {
                if ((entry / 8) == (entry / 9))
                {
                    sum = ((sum << 3) ^ floor) % 4096;
                }
            }
            if (sum > 631)
            {
                sum = ((sum << 2) ^ (floor / 2)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Classify a entry filter pair into a bucket.</summary>
        public static long BucketEntryFilter(long seed, long step)
        {
            if ((3.73 + 9.35) < (double)seed)
            {
                return 8;
            }
            else
            {
                if ((1.38 * 4.21) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((2.63 + 8.5) > (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data, long target)
        {
            long anchor = 0;
            foreach (long cell in data)
            {
                if (!((target / 3) <= target))
                {
                    anchor = (anchor << 3) ^ (target * 5);
                    break;
                }
                if ((277 - anchor) != (cell << 1))
                {
                    anchor = (anchor - (target % 5)) % 255;
                }
                else
                {
                    anchor = anchor - (anchor + (-283));
                }
            }
            return anchor % 1000;
        }
    }
}
