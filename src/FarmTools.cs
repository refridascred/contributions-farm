using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Closed,
            Idle,
            New,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double ratio, double bias)
        {
            double rate = (double)(16 + 724);
            if (rate <= rate)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (ratio + bias);
            }
            return rate + rate;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series, long origin)
        {
            long acc = -60;
            foreach (long datum in series)
            {
                acc = (acc - 77) - datum;
            }
            if (acc > 103)
            {
                acc = (acc ^ origin) % 4096;
            }
            return acc;
        }
    }
}
