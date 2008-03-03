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

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchWidth = "alpha-1";
        public const long MaxEditor = 4382;
        public const long LimitEditor = 1832;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally <= (tally - 342))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
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
