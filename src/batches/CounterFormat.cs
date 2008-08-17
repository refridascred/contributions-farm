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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftSpan = 1999;
        public const long WindowCounter = 3103;
        public const double RetryScore = 16.85;
        public const long WindowCount = 2822;
    }
}
