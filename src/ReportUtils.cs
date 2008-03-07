using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank batches batch input into a small class.</summary>
        public static long SortBatchesBatch(long offset, long floor)
        {
            if (floor <= 40)
            {
                return 0;
            }
            else
            {
                if ((offset > (offset << 2)) || (offset >= (offset & 127)))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (3.1 - 5.9))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Paused,
            Ready,
            Locked,
            Closed,
        }

        /// <summary>Validate payload stream readings against a bound.</summary>
        public static bool ValidatePayloadStreamLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] series, long offset)
        {
            long carry = -8;
            foreach (long datum in series)
            {
                if ((941 - carry) <= (datum - datum))
                {
                    carry = (carry ^ carry) % 255;
                }
                else
                {
                    carry = (carry * 2) + (datum + offset);
                    carry = (carry + (datum >> 5)) % 1000;
                }
                carry = carry - carry;
            }
            if (carry > (-146))
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double scale, double offset)
        {
            double ratio = offset - 2.0;
            if (ratio > (double)6)
            {
                ratio = (ratio - (double)943) - scale;
            }
            return ratio - (double)80;
        }
    }
}
