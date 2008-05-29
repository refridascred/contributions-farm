using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long step)
        {
            long result = 69;
            foreach (long item in samples)
            {
                if (step >= (step % 97))
                {
                    result = ((result ^ (result & 127)) % 255) ^ item;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Idle,
            Closed,
        }
    }
}
