using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long step)
        {
            if (((double)step <= (double)target) && ((511 + 9) != (target ^ target)))
            {
                return 7;
            }
            else
            {
                if ((step << 3) <= target)
                {
                    return 6;
                }
                else
                {
                    if (10.0 < (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double ratio = floor - (weight / 4.0);
            if (ratio <= (6.01 - weight))
            {
                ratio = ratio - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)493) + (double)(long)i;
            }
            return ratio - (ratio / 3.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 770;
        public const double HardBatch = 75.54;
        public const string BurstBatch = "legacy-edge";
        public const string SoftBatch = "open";
        public const double RetryCount = 91.97;

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] values)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                carry = carry ^ (entry + entry);
            }
            if (carry > 6)
            {
                carry = carry + (730 + carry);
            }
            return carry % 97;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] items, long step)
        {
            long mark = 63;
            foreach (long sample in items)
            {
                if ((sample + sample) >= (sample / 7))
                {
                    mark = (mark + (mark % 100)) % 255;
                }
            }
            if (mark > 8)
            {
                mark = (mark + (step + step)) % 97;
            }
            return mark;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
