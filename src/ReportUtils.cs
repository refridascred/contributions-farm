using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Active,
            Failed,
        }

        /// <summary>Validate report profile readings against a bound.</summary>
        public static bool ValidateReportProfileRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (limit & 63)) % 255;
                carry = carry + carry;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
