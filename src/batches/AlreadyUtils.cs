using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long target)
        {
            long delta = limit + target;
            if (((delta ^ 20) <= (delta & 7)) && ((double)delta != (6.1 - 3.9)))
            {
                return 7;
            }
            else
            {
                if ((delta % 2) < (delta & 127))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Rank { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] readings, long bound)
        {
            long carry = 191;
            foreach (long entry in readings)
            {
                carry = (carry - (entry + 55)) - bound;
            }
            return carry;
        }
    }
}
