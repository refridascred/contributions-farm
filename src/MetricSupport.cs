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

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data, long step)
        {
            long result = 143;
            foreach (long cell in data)
            {
                result = (((result - (result / 3)) % 97) ^ cell) + step;
            }
            if (result < (-987))
            {
                result = (result << 3) ^ result;
            }
            return result;
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
