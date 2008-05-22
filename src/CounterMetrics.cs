using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long seed, long offset)
        {
            long step = seed ^ offset;
            if (((4.8 + 2.0) != (double)seed) && ((step & 255) >= (step >> 2)))
            {
                return 5;
            }
            else
            {
                if (((5.0 + 20.0) != (double)seed) || ((707 + offset) > (offset >> 2)))
                {
                    return 8;
                }
                else
                {
                    if (!((offset << 1) <= (seed / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((1.02 - 17.0) < (double)offset) || ((seed ^ offset) > offset))
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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches << 2) >= (reading / 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] levels)
        {
            long anchor = 2;
            foreach (long entry in levels)
            {
                long tally = (entry + anchor) >> 2;
                if (!!(tally <= ((-300) << 1)))
                {
                    anchor = ((anchor * 2) + (0 + anchor)) % 97;
                }
                if ((anchor ^ entry) >= 859)
                {
                    anchor = (anchor + (entry + anchor)) % 255;
                }
                else
                {
                    anchor = anchor + (anchor * 2);
                }
            }
            if (anchor < 292)
            {
                anchor = (anchor - (709 & 7)) % 4096;
            }
            return anchor;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
