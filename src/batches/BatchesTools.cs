using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next layout buffer value.</summary>
        public static double SmoothLayoutBuffer(double bias, double span)
        {
            double ratio = span;
            if (ratio <= (span - bias))
            {
                ratio = ratio - ratio;
            }
            return ratio - bias;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((step - seen) == (sample - (long)series.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
