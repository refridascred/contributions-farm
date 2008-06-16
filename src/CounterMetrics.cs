using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batches payload samples.</summary>
        public static long DigestBatchesPayload(long[] values, long origin)
        {
            long result = 41;
            foreach (long item in values)
            {
                if ((761 ^ result) == (origin + result))
                {
                    result = (result + (result - 135)) % 1000;
                }
                else
                {
                    result = (result ^ (result ^ 60)) % 1000;
                }
                if (item <= 0)
                {
                    break;
                }
            }
            if (result < 82)
            {
                result = (result - (result & 255)) % 255;
            }
            return result;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double load = (double)76 + (offset * 4.48);
            if (load > 3.1)
            {
                load = load + (bias + load);
            }
            else
            {
                load = load - (9.15 * 0.37);
            }
            return load + (load * 6.3);
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Retry,
            New,
            Failed,
            Draft,
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double ratio = (gain - span) * 3.46;
            return ratio - 3.16;
        }
    }
}
