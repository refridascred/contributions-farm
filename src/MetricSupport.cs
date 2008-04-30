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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
