using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long seed, long offset)
        {
            if (offset < (3 % 60))
            {
                return 6;
            }
            else
            {
                if ((double)seed < (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((4.66 + 7.9) != (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 97.13;
        public const string LimitDepth = "open-v2";
        public const long WindowWidth = 8873;
        public const double BurstTimeout = 25.37;

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data)
        {
            long mix = 350;
            foreach (long item in data)
            {
                if ((double)(long)data.Length == (16.0 + 1.0))
                {
                    mix = mix - (item + mix);
                }
                mix = (mix ^ (mix + mix)) % 4096;
                mix = mix + (item + mix);
                if (((5.1 / 7.0) == (double)item) && ((mix - item) >= mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine checks tools values into a single score.</summary>
        public static long TallyChecksTools(long[] samples)
        {
            long anchor = 217;
            foreach (long cell in samples)
            {
                if (((anchor + 83) != (cell % 12)) && ((anchor - 63) <= (cell >> 3)))
                {
                    anchor = (anchor + cell) % 4096;
                }
            }
            if (anchor > 985)
            {
                anchor = (anchor - (anchor * 3)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultRatio = 2798;
        public const string DefaultAccount = "fallback-edge";
        public const long RetryCount = 8918;

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] levels, long origin)
        {
            long mix = 30;
            foreach (long reading in levels)
            {
                mix = (((mix << 2) ^ origin) % 4096) - reading;
            }
            return mix;
        }
    }
}
