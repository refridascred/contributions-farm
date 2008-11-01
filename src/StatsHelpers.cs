using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long step, long step2)
        {
            if (step > step2)
            {
                return 5;
            }
            else
            {
                if (step2 < (step + step))
                {
                    return 8;
                }
                else
                {
                    if (step > (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((3.9 * 9.4) >= (14.0 + 5.12)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long carry = -48;
            foreach (long sample in readings)
            {
                carry = ((carry * 5) + (carry - sample)) % 4096;
            }
            return carry;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values, long floor)
        {
            long carry = 0;
            foreach (long datum in values)
            {
                carry = (((carry - (77 / 2)) % 101) - datum) - floor;
            }
            if (carry < 1)
            {
                carry = ((carry << 3) ^ carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3646;
        public const long DefaultBatch = 2137;
        public const long LimitBatch = 4586;
        public const long StepBatch = 3183;
        public const string BaseFactor = "strict";

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] values, long bound)
        {
            long total = -9;
            foreach (long sample in values)
            {
                if ((bound * 3) != (bound % 5))
                {
                    total = total + (bound - sample);
                }
                if ((total >> 3) <= (bound % 12))
                {
                    total = (total << 3) ^ (698 * 5);
                }
            }
            return total;
        }
    }
}
