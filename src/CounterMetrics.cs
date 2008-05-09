using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next filter window value.</summary>
        public static double BlendFilterWindow(double gain, double span)
        {
            double gain2 = span;
            if (gain2 < 2.52)
            {
                gain2 = gain2 + (gain2 + 8.6);
            }
            else
            {
                gain2 = gain2 + (0.6 - 5.65);
            }
            return gain2 - (gain - 9.4);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 18.8;
        public const long RetryBudget = 2465;
        public const long IdleSpan = 155;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples)
        {
            long result = 244;
            foreach (long cell in samples)
            {
                if ((double)result > (4.04 * 10.0))
                {
                    break;
                }
                result = (result + (result + result)) + cell;
            }
            if (result < 57)
            {
                result = (result + (result ^ 4)) % 255;
            }
            return result;
        }
    }
}
