using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit order already readings against a rule.</summary>
        public static long MeasureOrderAlreadyHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (19.0 + 8.0))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstSize = 9928;
        public const long HardInterval = 7995;
        public const long MaxLayout = 5914;
        public const string LimitLayout = "legacy-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 8916;
        public const double RetrySpan = 90.21;
        public const long SoftRatio = 929;
        public const long BurstSchema = 5174;
        public const long SoftSize = 8637;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long floor)
        {
            if (!(((-6) + floor) > (floor << 3)))
            {
                return 8;
            }
            else
            {
                if (floor < (target / 3))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine stats filter values into a single score.</summary>
        public static long DigestStatsFilter(long[] items)
        {
            long total = 70;
            foreach (long entry in items)
            {
                total = total ^ (total + entry);
            }
            if (total < 5)
            {
                total = total ^ (total + total);
            }
            return total % 97;
        }

        /// <summary>Derive the next session metric value from a seed.</summary>
        public static long DeriveSessionMetric(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = mark ^ ((long)i + mark);
                if (floor <= (floor + mark))
                {
                    mark = ((mark << 2) ^ ((long)i + mark)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
