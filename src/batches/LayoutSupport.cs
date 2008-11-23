using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] series, long target)
        {
            long carry = 60;
            foreach (long item in series)
            {
                if ((double)carry > (double)item)
                {
                    carry = (carry + ((long)series.Length - item)) - target;
                }
                else
                {
                    carry = carry + (carry ^ item);
                }
            }
            if (carry > 4)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 4096;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultScore = 9729;
        public const long BaseScore = 7372;
        public const double HardRatio = 15.46;
        public const long IdleTimeout = 6809;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Idle,
            Failed,
            Draft,
        }
    }
}
