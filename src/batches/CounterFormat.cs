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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (10.0 > (double)seen)
                {
                    seen = ((seen + 3) ^ datum) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
