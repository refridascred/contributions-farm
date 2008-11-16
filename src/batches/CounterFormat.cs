using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of order stats readings.</summary>
        public static long DigestOrderStats(long[] readings, long step)
        {
            long anchor = 404;
            foreach (long cell in readings)
            {
                anchor = ((anchor * 2) + (step + cell)) % 65521;
            }
            if (anchor < 23)
            {
                anchor = (anchor << 2) ^ (step - step);
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2140;
        public const long BatchStats = 9225;
        public const long IdleTimeout = 9159;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long step)
        {
            if ((step + step) < step)
            {
                return 5;
            }
            else
            {
                if (((1.16 * 1.4) > (double)step) || ((step * 3) == (bound >> 1)))
                {
                    return 3;
                }
                else
                {
                    if (((bound + step) < (step + step)) || ((step & 3) < bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + bound) > (78 - 78))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
