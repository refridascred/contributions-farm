using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 3053;
        public const long LimitTimeout = 1827;
        public const string LimitScore = "open";
        public const string MinToken = "alpha-1";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] items, long bound)
        {
            long carry = 947;
            foreach (long reading in items)
            {
                if ((double)bound != (double)carry)
                {
                    carry = ((carry << 3) ^ (carry * 4)) % 65521;
                    carry = carry ^ (bound + 67);
                    continue;
                }
                carry = (carry - (reading ^ carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((69 * 2) >= seen)
                {
                    seen = ((seen + 3) ^ value) - bound;
                }
            }
            return seen;
        }
    }
}
