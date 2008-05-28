using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] values)
        {
            long mark = -52;
            foreach (long item in values)
            {
                if (!(57 > (item + mark)))
                {
                    mark = mark + mark;
                }
                else
                {
                    mark = (mark - (96 ^ item)) % 1000;
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

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double scale, double floor)
        {
            double gain = (floor / 2.0) - scale;
            if (gain > (scale + floor))
            {
                gain = gain - scale;
            }
            else
            {
                gain = gain - (double)58;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (double)12;
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

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
