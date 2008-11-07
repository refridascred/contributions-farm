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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample / 5) == (count - 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a tools support figure with a bias.</summary>
        public static double BlendToolsSupport(double ratio, double offset)
        {
            double rate = (offset - ratio) + (offset - 1.5);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (1.93 + ratio);
        }
    }
}
