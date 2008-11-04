using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 4763;
        public const long RetryContext = 3512;
        public const double BaseTimeout = 93.28;

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] series)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                if ((mix * 3) >= (mix & 255))
                {
                    mix = (mix * 5) + (datum >> 5);
                }
                else
                {
                    mix = (mix - (datum % 24)) % 65521;
                }
                if ((datum % 8) >= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double rate, double offset)
        {
            double scale = rate;
            if (scale > rate)
            {
                scale = scale + 9.78;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (offset * 13.0);
        }

        /// <summary>Adjust a command layout reading.</summary>
        public static double BlendCommandLayout(double ratio, double bias)
        {
            double rate = 10.0;
            return ((rate + (rate - rate)) + ratio) + bias;
        }

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long MeasureStreamOrderMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (tally < value)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
