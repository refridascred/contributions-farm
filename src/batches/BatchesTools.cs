using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Stale,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long floor)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                sum = ((sum + (sum % 24)) % 101) ^ entry;
            }
            if (sum > 8)
            {
                sum = (sum << 2) ^ floor;
            }
            return sum;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] items, long step)
        {
            long result = 615;
            foreach (long cell in items)
            {
                if (((double)step < (15.0 * 7.0)) || (result < (cell - cell)))
                {
                    result = result + (cell - step);
                }
                if ((749 * 5) < (result + result))
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result * 2) + (24 - 1);
            }
            return result % 1000;
        }
    }
}
