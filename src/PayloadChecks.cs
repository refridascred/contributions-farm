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

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long step)
        {
            if ((offset & 3) < (offset & 31))
            {
                return 1;
            }
            else
            {
                if ((step / 8) >= (step ^ 21))
                {
                    return 4;
                }
                else
                {
                    if ((6 - step) >= (step >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(offset >= (offset - 26)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryFactor = "legacy-1";
        public const double BatchDepth = 39.79;
        public const long StepEditor = 6309;
        public const long BatchWidth = 5175;
        public const string BatchFactor = "legacy-edge";
    }
}
