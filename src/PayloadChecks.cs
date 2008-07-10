using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long sum = 3;
            foreach (long datum in samples)
            {
                if (sum < (sum - (-6)))
                {
                    sum = (sum << 2) ^ (datum + sum);
                }
            }
            if (sum > 231)
            {
                sum = ((sum << 2) ^ (178 - sum)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 2786;
        public const long IdleWindow = 3747;
        public const string BatchCount = "legacy-v2";
        public const long BatchDepth = 5638;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of contributi checks readings.</summary>
        public static long ScoreContributiChecks(long[] levels, long step)
        {
            long carry = 58;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry << 3) ^ (long)i) % 101) + cell;
                    carry = ((carry << 3) ^ (3 << 1)) % 255;
                }
                carry = (carry * 5) + (0 % 2);
            }
            if (carry > (-69))
            {
                carry = (carry * 4) + (step ^ 80);
            }
            return carry;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell - tally) == (91 / 7))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 4187;
        public const double RetrySpan = 43.11;
        public const long BatchMetric = 8573;
        public const long BurstInterval = 7638;
        public const string BurstBudget = "alpha-1";
    }
}
