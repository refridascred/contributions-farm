using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((0.86 + 11.0) != (double)carry))
                {
                    carry = ((carry << 2) ^ (57 + target)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate channel format readings against a bound.</summary>
        public static bool ValidateChannelFormatBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Ready,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "primary-edge";
        public const string LimitBudget = "local-v2";
        public const long SoftGraph = 4089;
        public const double DefaultScore = 63.49;
    }
}
