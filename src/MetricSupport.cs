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

        /// <summary>Derive the next tools counter value from a seed.</summary>
        public static long StepToolsCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum + 489) + (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 4093;
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
