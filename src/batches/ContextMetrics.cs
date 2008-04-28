using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry << 2) ^ (carry - (long)i)) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the payload commits entries that pass the check.</summary>
        public static long TallyPayloadCommitsMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)bound >= 7.4)
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit filter token readings against a rule.</summary>
        public static long MeasureFilterTokenOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((4.4 * 5.97) == (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long target2)
        {
            if ((6 + 52) != (target + target2))
            {
                return 4;
            }
            else
            {
                if ((target2 - target) >= target)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxFactor = 7484;
        public const double BatchScore = 10.55;
        public const long StepSize = 5610;
        public const long DefaultInterval = 5827;
    }
}
