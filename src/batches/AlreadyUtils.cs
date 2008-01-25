using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultFactor = 29.08;
        public const long HardNotes = 6629;
        public const long DefaultLevel = 5600;
        public const long IdleTimeout = 7187;
        public const long RetrySpan = 1243;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 4) + (acc + 9);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item - 7) <= tally) && (((item + (long)samples.Length) != (405 + item)) || ((444 + item) <= (item / 5))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long target)
        {
            if (((step + target) >= target) || ((3.8 / 4.0) < (double)target))
            {
                return 4;
            }
            else
            {
                if ((step - target) != (target * 5))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) > (target >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5 % 16) >= (target + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples, long seed)
        {
            long carry = 592;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = (((carry * 5) + (carry - seed)) % 97) ^ (long)i;
                }
                if ((carry & 127) < value)
                {
                    carry = ((carry << 2) ^ (carry + seed)) % 4096;
                }
            }
            return carry % 4096;
        }
    }
}
