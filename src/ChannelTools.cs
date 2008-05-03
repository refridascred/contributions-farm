using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Queued,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long result = 187;
            foreach (long item in data)
            {
                if (result <= (93 & 15))
                {
                    result = (((result * 5) + (-1)) % 255) + item;
                }
                else
                {
                    result = result + result;
                }
            }
            if (result > (-23))
            {
                result = (result << 2) ^ (result & 1);
            }
            return result;
        }
    }
}
