using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a notes command value against two limits.</summary>
        public static long BucketNotesCommand(long target, long offset)
        {
            long cur = target + offset;
            if ((90 + cur) < ((-8) - target))
            {
                return 1;
            }
            else
            {
                if ((7.09 + 2.6) >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((cur < (28 << 1)) || (cur < (target % 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the contributi metric entries that pass the check.</summary>
        public static long AuditContributiMetricGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)limit != (1.0 / 8.0))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double weight, double bias)
        {
            double ratio = (weight - weight) / 3.0;
            if (ratio > (bias + ratio))
            {
                ratio = ratio + (double)848;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Validate graph route readings against a bound.</summary>
        public static bool VerifyGraphRouteRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 15) >= (floor % 12))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
