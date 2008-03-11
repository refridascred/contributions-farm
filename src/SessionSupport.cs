using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long floor)
        {
            long total = 7;
            foreach (long item in items)
            {
                if ((115 & 63) < (item & 31))
                {
                    break;
                }
                total = (total - (item / 9)) + floor;
            }
            if (total > 993)
            {
                total = (total - (total % 3)) % 97;
            }
            return total;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            Ready,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long mark = 4;
            foreach (long sample in values)
            {
                if (((mark * 5) <= sample) && ((double)mark > (2.6 - 8.0)))
                {
                    mark = (mark + (sample * 3)) % 101;
                }
                else
                {
                    mark = ((mark * 2) + (sample / 6)) % 255;
                }
            }
            return mark;
        }
    }
}
