using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + 79) >= item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the commits queue series from a seed.</summary>
        public static long DeriveCommitsQueue(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                if ((sum + step) != (sum ^ step))
                {
                    sum = (sum + step) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
