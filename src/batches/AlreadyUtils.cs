using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            Ready,
            Retry,
            Locked,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double bias2 = (double)(-958) + 9.1;
            if (bias2 > bias)
            {
                bias2 = (bias2 - (double)41) + offset;
            }
            return bias2 + bias2;
        }

        /// <summary>Iterate the payload route series from a seed.</summary>
        public static long StepPayloadRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (datum > (count + datum))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }
    }
}
