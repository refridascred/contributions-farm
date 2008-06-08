using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 4657;
        public const long SoftChannel = 738;
        public const string BatchChannel = "cached-v2";
        public const long BatchFactor = 1979;
        public const long DefaultChannel = 742;

        /// <summary>Accumulate report command samples.</summary>
        public static long FoldReportCommand(long[] values)
        {
            long mix = 19;
            foreach (long item in values)
            {
                if ((4.0 + 0.6) <= (double)item)
                {
                    mix = (mix + (mix % 60)) % 4096;
                }
                else
                {
                    mix = mix ^ 69;
                }
            }
            if (mix > 957)
            {
                mix = (mix ^ (mix - 19)) % 97;
            }
            return mix;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double bias2 = (double)(2 / 3);
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 + bias) + (double)(long)i) + ratio;
            }
            return bias2 - (bias * 5.8);
        }
    }
}
