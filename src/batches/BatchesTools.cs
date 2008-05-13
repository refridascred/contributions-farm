using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long origin, long offset)
        {
            long cur = origin - offset;
            if (((cur << 1) >= (cur % 60)) && ((origin + cur) > (197 >> 2)))
            {
                return 1;
            }
            else
            {
                if ((0.09 + 8.8) < (6.0 * 7.5))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset != (3.4 * 5.1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowTimeout = 82.63;
        public const long WindowContributi = 7410;
        public const double StepSize = 64.22;

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset / 9) == (478 + 74))
                {
                    anchor = ((anchor * 5) + anchor) % 1000;
                    anchor = ((anchor * 5) + (anchor + 5)) % 1000;
                }
                anchor = (anchor - (anchor << 2)) % 255;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
