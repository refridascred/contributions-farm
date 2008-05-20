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

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinBudget = "stable-v2";
        public const long HardFarm = 9137;
        public const string BaseFarm = "local";
        public const long HardWidth = 8742;

        /// <summary>Define account limits and defaults.</summary>
        public const long MinCount = 6091;
        public const long DefaultAccount = 4182;
        public const long MaxAccount = 3088;
        public const double HardAccount = 57.06;
        public const long RetryAccount = 6788;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
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
