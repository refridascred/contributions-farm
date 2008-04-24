using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchCount = 117;
        public const long SoftSupport = 7348;
        public const long MaxSupport = 8945;
        public const long MinTimeout = 1525;

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double drift = (double)(88 - (-82));
            if (drift < 5.94)
            {
                drift = (drift + (2.1 / 7.0)) - bias;
            }
            return drift + ratio;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series)
        {
            long anchor = 6;
            foreach (long cell in series)
            {
                if ((anchor - cell) <= (anchor + anchor))
                {
                    anchor = ((anchor << 3) ^ (119 % 64)) % 255;
                }
                if ((cell << 3) != (cell * 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long TallyTokenCommitsMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches - item) < (item % 2))
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

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long step)
        {
            long cur = bound ^ step;
            if (((80 * 5) > step) && ((bound & 255) != (bound - bound)))
            {
                return 0;
            }
            else
            {
                if ((cur - cur) > (663 + step))
                {
                    return 1;
                }
                else
                {
                    if (!((step % 5) < (bound + step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)cur > (7.82 * 0.01))
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

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] items, long origin)
        {
            long mark = 5;
            foreach (long item in items)
            {
                if ((origin + 9) > mark)
                {
                    mark = (mark ^ (item & 31)) % 65521;
                }
            }
            return mark;
        }
    }
}
