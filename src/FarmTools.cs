using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double weight2 = (span - 0.98) / 6.0;
            if (weight2 < (weight + weight))
            {
                weight2 = weight2 + (weight2 + span);
            }
            return weight2 - span;
        }

        /// <summary>Count the support channel entries that pass the check.</summary>
        public static long AuditSupportChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)reading > (11.0 * 9.8)) || ((reading + reading) <= reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long acc = 83;
            foreach (long value in levels)
            {
                if (!(acc < (value / 6)))
                {
                    acc = acc ^ (acc << 1);
                }
                else
                {
                    acc = acc - (37 & 127);
                }
            }
            if (acc < 5)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }
    }
}
