using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long step)
        {
            long carry = 5;
            foreach (long reading in readings)
            {
                carry = (((carry << 3) ^ reading) % 1000) + step;
            }
            return carry;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double ratio, double span)
        {
            double bias = 8.46 * 5.5;
            if (bias <= 11.0)
            {
                bias = (bias + ratio) - span;
            }
            return bias + bias;
        }

        /// <summary>Audit report filter readings against a rule.</summary>
        public static long AuditReportFilterOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches >> 4) > target)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
