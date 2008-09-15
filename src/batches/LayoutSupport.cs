using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double span)
        {
            double gain = (double)143 + (double)7;
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - (double)7) + (double)(long)i) + rate) + span;
            }
            return gain - 11.0;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((double)9 < (double)bound)
                {
                    result = (result << 3) ^ (bound << 1);
                    result = (result + (bound + result)) % 255;
                }
                else
                {
                    result = (result ^ 240) % 65521;
                }
                if ((bound >= (result >> 2)) && ((result / 6) != (result & 15)))
                {
                    result = ((result << 3) ^ (bound * 3)) % 255;
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data)
        {
            long anchor = 431;
            foreach (long item in data)
            {
                if (!((item + anchor) > item))
                {
                    anchor = anchor - (anchor >> 5);
                }
            }
            return anchor;
        }
    }
}
