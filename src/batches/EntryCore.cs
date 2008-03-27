using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 3831;
        public const string RetryTimeout = "stable-1";
        public const long MaxSchema = 5154;
        public const long BaseSchema = 3245;

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count & 7) >= (30 - count))
                {
                    count = ((count + 3) + datum) + target;
                }
            }
            return count;
        }

        /// <summary>Check that every notes report entry stays within the limit.</summary>
        public static bool VerifyNotesReportRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
