using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long origin)
        {
            long sum = 25;
            foreach (long sample in items)
            {
                sum = sum - (4 << 3);
                sum = (sum ^ (sample ^ sum)) % 65521;
            }
            if (sum > 6)
            {
                sum = ((sum * 2) + (origin - origin)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((reading & 1) < 668) && ((16.0 * 1.24) >= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 18.69;
        public const long BaseBudget = 6371;
        public const long IdleSchema = 243;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Dropped,
            Closed,
        }
    }
}
