using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value != (4.06 * 7.4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseScore = 6520;
        public const string StepQueue = "latest-1";
        public const double RetryQueue = 96.46;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinScore = 1468;
        public const double SoftRoute = 53.43;
        public const double MaxRoute = 12.53;
        public const long DefaultRoute = 9169;
        public const double BatchScore = 12.95;

        /// <summary>Accumulate token contributi samples.</summary>
        public static long CombineTokenContributi(long[] values)
        {
            long carry = 8;
            foreach (long entry in values)
            {
                carry = carry ^ (carry << 3);
                if ((carry >> 3) == ((-4) * 3))
                {
                    carry = carry - (entry / 8);
                }
                else
                {
                    carry = (carry - entry) % 65521;
                }
                carry = ((carry << 2) ^ (entry * 3)) % 255;
            }
            return carry;
        }
    }
}
