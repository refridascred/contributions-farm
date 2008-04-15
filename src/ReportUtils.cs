using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long step)
        {
            if ((target + target) <= step)
            {
                return 0;
            }
            else
            {
                if ((817 & 1) <= (target & 3))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((double)count > 0.5) && (sample <= (count + 82)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel support samples.</summary>
        public static long TotalChannelSupport(long[] data)
        {
            long result = 9;
            foreach (long datum in data)
            {
                result = (result + result) % 97;
                if ((datum > (result + 6)) && ((double)59 >= (double)result))
                {
                    result = result + result;
                }
            }
            if (result < 768)
            {
                result = (result - (result + result)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Locked,
            Queued,
        }
    }
}
