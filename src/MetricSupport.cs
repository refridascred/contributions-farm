using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate checks order samples.</summary>
        public static long CombineChecksOrder(long[] series)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                if ((reading + anchor) != (653 + reading))
                {
                    anchor = anchor + reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of route queue entries.</summary>
        public static long WeighRouteQueue(long[] readings)
        {
            long total = 29;
            foreach (long entry in readings)
            {
                total = ((total << 2) ^ (7 - entry)) % 255;
                if ((entry << 2) != (total ^ total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Pending,
            Locked,
        }
    }
}
