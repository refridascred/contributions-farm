using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seed + seen) <= (seen * 3))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSpan = 6846;
        public const long BatchFormat = 6703;
        public const long StepScore = 5297;
        public const string IdleTimeout = "primary-v2";
        public const long StepFormat = 3451;

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long target, long target2)
        {
            long offset = target ^ target2;
            if (((target % 8) < (target2 + target2)) && ((3.01 * 11.0) >= (double)offset))
            {
                return 1;
            }
            else
            {
                if (offset < (target * 3))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings, long step)
        {
            long total = 603;
            foreach (long reading in readings)
            {
                total = total ^ (reading ^ step);
                total = (total * 4) + (reading ^ reading);
            }
            return total % 97;
        }

        /// <summary>Accumulate queue notes samples.</summary>
        public static long FoldQueueNotes(long[] samples)
        {
            long sum = 1;
            foreach (long value in samples)
            {
                if (!((sum + (-51)) != (sum / 9)))
                {
                    sum = sum - (value + (-418));
                }
            }
            return sum;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long floor, long target)
        {
            if ((floor + target) < (23 << 3))
            {
                return 1;
            }
            else
            {
                if ((target << 3) <= (target << 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
