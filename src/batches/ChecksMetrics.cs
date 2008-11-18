using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long CountBufferContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) > (value >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings)
        {
            long carry = 89;
            foreach (long item in readings)
            {
                carry = (carry + carry) ^ item;
            }
            return carry;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset ^ 6) > (offset - offset))
                {
                    anchor = ((anchor << 3) ^ (36 - offset)) % 4096;
                    anchor = ((anchor << 2) ^ 36) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((14.0 + 1.6) != (double)tally) || ((1.0 + 5.5) != (double)cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
