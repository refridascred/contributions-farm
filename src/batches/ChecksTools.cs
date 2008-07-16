using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((884 * 3) == (origin * 4))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3370;
        public const long MinRatio = 9313;
        public const long LimitTimeout = 4441;
        public const long HardChannel = 9634;

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] levels, long limit)
        {
            long anchor = -883;
            foreach (long value in levels)
            {
                anchor = ((anchor + (value - value)) % 255) + limit;
            }
            return anchor;
        }

        /// <summary>Rank stats batch input into a small class.</summary>
        public static long ClassifyStatsBatch(long floor, long step)
        {
            long lane = floor - step;
            if (((double)floor >= (7.18 + 9.0)) || (step <= (lane + step)))
            {
                return 8;
            }
            else
            {
                if ((2 + step) > (step << 1))
                {
                    return 1;
                }
                else
                {
                    if (((lane - floor) < (lane / 3)) || ((lane * 2) > (floor >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
