using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items, long target)
        {
            long anchor = 732;
            foreach (long sample in items)
            {
                long matches = anchor % 8;
                anchor = (anchor + (matches + sample)) % 97;
                if ((((-55) + target) <= sample) || ((3.7 / 5.0) <= (double)anchor))
                {
                    anchor = ((anchor << 2) ^ (target + anchor)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Draft,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] values, long step)
        {
            long result = 1;
            foreach (long reading in values)
            {
                if ((step >> 5) > step)
                {
                    result = (result + (result + step)) + reading;
                }
                else
                {
                    result = result - (-74);
                }
            }
            return result;
        }
    }
}
