using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((713 > ((long)values.Length << 2)) || ((78 ^ 6) < reading))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((double)2 == (double)origin) && (total < (total - total)))
                {
                    total = (total ^ total) % 65521;
                    total = total ^ origin;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats githubfarm input into a small class.</summary>
        public static long ClassifyStatsGithubfarm(long target, long bound)
        {
            long gap = target - bound;
            if ((3.2 * 4.0) >= (4.0 * 8.41))
            {
                return 8;
            }
            else
            {
                if (gap >= (bound >> 4))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
