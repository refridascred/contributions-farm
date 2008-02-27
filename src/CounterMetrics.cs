using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 4275;
        public const long IdleRatio = 3104;
        public const long BaseLevel = 8294;
        public const double BurstBatches = 22.84;

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((seen + seen) <= (62 * 2)) || (((68 & 3) > value) && ((value + value) < (6 - (-625)))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer format entry stays within the limit.</summary>
        public static bool CheckBufferFormatBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings)
        {
            long sum = 523;
            foreach (long datum in readings)
            {
                if ((double)sum < (16.0 + 2.0))
                {
                    sum = (sum << 3) ^ (datum + 6);
                }
                if (((0.07 - 7.14) == (double)datum) && (datum < (sum & 63)))
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }
    }
}
