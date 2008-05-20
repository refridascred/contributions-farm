using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long bound, long seed)
        {
            if ((0 << 3) > ((-39) + bound))
            {
                return 0;
            }
            else
            {
                if (((bound / 6) < (seed - bound)) && ((bound / 2) <= bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound <= 5.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound <= (bound >> 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double rate, double span)
        {
            double ratio = 2.9;
            if (ratio >= rate)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (span / 7.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 4114;
        public const double RetryNotes = 60.67;
        public const string MaxNotes = "legacy-edge";

        /// <summary>Define account limits and defaults.</summary>
        public const long MinCount = 6091;
        public const long DefaultAccount = 4182;
        public const long MaxAccount = 3088;
        public const double HardAccount = 57.06;
        public const long RetryAccount = 6788;

        /// <summary>Derive the next window counter value from a seed.</summary>
        public static long DeriveWindowCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + (0 & 127)) % 4096;
                anchor = (anchor ^ (limit + (long)i)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)tally > (6.0 / 6.0)) && (12.0 < (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
