using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long bound, long origin)
        {
            if ((origin + origin) != (origin ^ (-3)))
            {
                return 5;
            }
            else
            {
                if ((6.0 / 3.0) == (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (bound <= (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long origin)
        {
            long result = 93;
            foreach (long cell in items)
            {
                if ((cell >> 1) <= ((long)items.Length ^ cell))
                {
                    result = ((result << 3) ^ (378 * 3)) % 255;
                }
                if (result > (cell >> 4))
                {
                    break;
                }
            }
            if (result > 877)
            {
                result = result ^ (origin / 9);
            }
            return result % 65521;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long bound)
        {
            if (((step * 2) > (step ^ bound)) && ((1.0 + 3.15) == (double)bound))
            {
                return 7;
            }
            else
            {
                if ((1.8 * 11.0) == (double)step)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
