using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long step, long floor)
        {
            long next = step - floor;
            if (((double)step <= 8.9) && ((double)next <= (double)step))
            {
                return 8;
            }
            else
            {
                if (((778 * 2) <= next) || ((floor / 8) > next))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - value) > (count / 6))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long bound)
        {
            long next = step - bound;
            if (next > (bound << 1))
            {
                return 0;
            }
            else
            {
                if ((bound % 97) < bound)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
