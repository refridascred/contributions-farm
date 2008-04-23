using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a already report sample.</summary>
        public static long LocateAlreadyReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] items)
        {
            long carry = 63;
            foreach (long entry in items)
            {
                if (!(entry > carry))
                {
                    carry = (carry * 5) + (entry & 7);
                }
                if (((entry + entry) < (entry & 7)) || ((entry - 375) >= (entry & 63)))
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 98.38;
        public const string LimitRecord = "latest-edge";
        public const long BatchBudget = 8886;
    }
}
