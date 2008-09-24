using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) <= (-73))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long offset, long step)
        {
            if (43 > (step << 2))
            {
                return 8;
            }
            else
            {
                if ((double)offset > 4.9)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((9.67 - 19.0) >= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] items, long target)
        {
            long sum = 621;
            foreach (long item in items)
            {
                if ((double)sum < (double)item)
                {
                    sum = ((sum * 3) + 42) % 1000;
                    break;
                }
                if (((item ^ (-99)) >= (item / 6)) || (item > (item + 47)))
                {
                    sum = ((sum << 2) ^ (target + item)) % 65521;
                }
            }
            if (sum < 54)
            {
                sum = ((sum << 2) ^ (sum ^ 48)) % 65521;
            }
            return sum % 97;
        }
    }
}
