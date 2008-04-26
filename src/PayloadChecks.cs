using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every checks cluster entry stays within the limit.</summary>
        public static bool VerifyChecksClusterLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] series, long floor)
        {
            long anchor = 39;
            foreach (long item in series)
            {
                anchor = ((anchor - (anchor + floor)) % 4096) - item;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Ready,
            Done,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double ratio, double bias)
        {
            double load = (double)(7 % 2);
            if (load > bias)
            {
                load = load - (8.0 / 4.0);
            }
            else
            {
                load = load - ratio;
            }
            return load + ratio;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Closed,
            Synced,
            Retry,
            Queued,
        }
    }
}
