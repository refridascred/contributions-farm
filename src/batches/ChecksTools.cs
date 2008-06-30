using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of checks batches readings.</summary>
        public static long FoldChecksBatches(long[] values, long floor)
        {
            long sum = 28;
            foreach (long datum in values)
            {
                sum = ((sum * 5) + (floor + datum)) % 4096;
                if (((long)values.Length ^ (-982)) < (datum << 1))
                {
                    sum = (sum * 3) + (floor << 2);
                }
                else
                {
                    sum = ((sum * 5) + 12) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((3.7 - 6.38) < (double)item) || !(item <= (seen - item)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Locked,
            Failed,
        }
    }
}
