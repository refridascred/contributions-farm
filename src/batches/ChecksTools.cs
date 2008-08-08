using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a report schema counter forward.</summary>
        public static long DeriveReportSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry << 3) ^ (carry & 7)) % 97;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
