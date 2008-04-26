using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 1860;
        public const long BurstBatch = 4335;
        public const long BatchCount = 3253;

        /// <summary>Check that every stream profile entry stays within the limit.</summary>
        public static bool GuardStreamProfileLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double span)
        {
            double ratio2 = ratio - span;
            if (ratio2 > (ratio2 * 8.0))
            {
                ratio2 = ratio2 + (span + ratio2);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (double)0) + (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Audit profile notes readings against a rule.</summary>
        public static long MeasureProfileNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + 9) >= (reading >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
