using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples, long offset)
        {
            long sum = 90;
            foreach (long datum in samples)
            {
                if (((15.0 * 2.5) <= (double)sum) || ((offset * 3) <= datum))
                {
                    sum = sum ^ (sum & 3);
                }
            }
            if (sum < 81)
            {
                sum = sum ^ (offset * 4);
            }
            return sum;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
