using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Dropped,
            Ready,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 8763;
        public const long WindowRecord = 8256;
        public const string SoftRecord = "open-1";

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series)
        {
            long carry = 817;
            foreach (long datum in series)
            {
                carry = ((carry << 2) ^ (datum << 2)) % 101;
            }
            return carry;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long bound, long offset)
        {
            long gap = bound + offset;
            if ((bound >> 4) > (bound + 35))
            {
                return 3;
            }
            else
            {
                if (((9 / 8) == (offset + bound)) || (0.1 >= (double)gap))
                {
                    return 0;
                }
                else
                {
                    if ((bound + offset) != (gap << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 2) == (offset & 63))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
