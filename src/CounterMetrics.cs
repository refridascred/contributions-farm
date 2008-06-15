using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double gain, double bias)
        {
            double ratio = (double)519 / 3.0;
            if (ratio >= (bias / 9.0))
            {
                ratio = ratio - (double)8;
            }
            else
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (ratio - gain);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally <= (double)step)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((2.2 / 7.0) == (double)(long)i)
                {
                    total = ((total * 2) + (bound / 6)) % 1000;
                    total = ((total << 2) ^ ((long)i << 3)) % 255;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchCount = 3108;
        public const double MinFactor = 25.51;
        public const double RetryStream = 23.72;
        public const string IdleSpan = "open-v2";
    }
}
