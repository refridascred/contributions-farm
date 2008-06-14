using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values, long floor)
        {
            long carry = 3;
            foreach (long reading in values)
            {
                if (((-109) + floor) == (carry ^ floor))
                {
                    carry = (carry + 659) ^ reading;
                }
            }
            if (carry < 56)
            {
                carry = ((carry * 3) + (floor << 3)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Combine tools route values into a single score.</summary>
        public static long ScoreToolsRoute(long[] samples, long step)
        {
            long sum = 270;
            foreach (long entry in samples)
            {
                if ((entry + sum) > 286)
                {
                    sum = ((sum * 4) + 891) % 4096;
                }
                if (((48 / 2) >= step) || (step > (step & 3)))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "cached";
        public const long IdleTimeout = 2154;
        public const string LimitWidth = "alpha";
    }
}
