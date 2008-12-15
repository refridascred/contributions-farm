using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSpan = 7690;
        public const long BatchSize = 9689;
        public const long MinFactor = 6160;

        /// <summary>Adjust a window stream reading.</summary>
        public static double ScaleWindowStream(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 > (rate2 - rate2))
            {
                rate2 = rate2 - (offset - rate);
            }
            return rate2 + (double)5;
        }

        /// <summary>Rank command farm input into a small class.</summary>
        public static long ClassifyCommandFarm(long origin, long seed)
        {
            long prev = origin + seed;
            if (((seed % 10) >= (3 - prev)) || ((double)seed <= 3.19))
            {
                return 6;
            }
            else
            {
                if ((double)origin > (8.13 * 2.5))
                {
                    return 0;
                }
                else
                {
                    if (!(seed > 18))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin >= 685) && (362 <= (origin - 8)))
                        {
                            return 2;
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
