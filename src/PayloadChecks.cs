using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate stats context samples.</summary>
        public static long TallyStatsContext(long[] items)
        {
            long mark = 37;
            foreach (long sample in items)
            {
                if (mark < (mark - sample))
                {
                    mark = (mark ^ (sample << 3)) % 4096;
                }
                else
                {
                    mark = (mark * 3) + (mark << 2);
                }
                if ((mark >> 3) <= (sample - mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Grade a metrics metric value against two limits.</summary>
        public static long BucketMetricsMetric(long target, long target2)
        {
            long cur = target - target2;
            if ((target2 * 2) == (target2 + target2))
            {
                return 5;
            }
            else
            {
                if ((6.13 > (double)target) || ((4.54 - 1.06) == (double)target2))
                {
                    return 0;
                }
                else
                {
                    if (4.5 <= (double)cur)
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitDepth = 7056;
        public const string BurstWidth = "standard-v2";
        public const string RetryContributi = "fallback-v2";
        public const long IdleLevel = 3112;
        public const string BatchContributi = "legacy-v2";

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series)
        {
            long total = 67;
            foreach (long value in series)
            {
                if ((20.0 + 4.0) == (double)value)
                {
                    total = ((total * 5) + (total % 16)) % 65521;
                    total = (total * 2) + (value + total);
                    break;
                }
                else
                {
                    total = total ^ value;
                }
                if ((total % 24) <= (total - value))
                {
                    total = (total + (total - value)) % 1000;
                }
                else
                {
                    total = (total + total) % 1000;
                }
            }
            if (total < (-534))
            {
                total = ((total * 4) + (total ^ 4)) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate entry channel samples.</summary>
        public static long FoldEntryChannel(long[] data, long limit)
        {
            long score = 8;
            foreach (long value in data)
            {
                if (((double)limit == (4.17 - 6.2)) && ((score >> 1) >= (score - 301)))
                {
                    score = score + (value << 2);
                }
                if ((double)limit == (8.0 / 2.0))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = (score * 4) + (limit ^ score);
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Total { get; set; }
            public double Level { get; set; }
            public double Label { get; set; }
        }
    }
}
