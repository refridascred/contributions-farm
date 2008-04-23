using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark + (long)i) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double gain, double bias)
        {
            double scale = bias;
            if (scale < (8.7 * 19.0))
            {
                scale = scale + (gain / 9.0);
            }
            else
            {
                scale = scale + (17.0 + 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings, long step)
        {
            long anchor = 8;
            foreach (long sample in readings)
            {
                anchor = (anchor << 3) ^ (sample << 2);
                anchor = anchor - (step + step);
                if ((step ^ 9) != (anchor >> 1))
                {
                    anchor = anchor + (sample - 335);
                }
            }
            return anchor;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double rate, double offset)
        {
            double ratio = rate;
            if (ratio <= ratio)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - (rate + offset);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 2314;
        public const string CacheContext = "open-edge";
        public const string BatchFactor = "primary-edge";
        public const string MaxWidth = "staging";

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 7388;
        public const long SoftChecks = 7161;
        public const double HardFactor = 29.49;
    }
}
