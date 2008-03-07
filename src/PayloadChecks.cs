using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 7165;
        public const long WindowGraph = 8658;
        public const string IdleSize = "legacy";
        public const long CacheSize = 210;
        public const long MinLevel = 3043;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long target, long step)
        {
            long span = target - step;
            if (((span / 3) < (target - step)) && ((target + step) <= target))
            {
                return 4;
            }
            else
            {
                if (!((span << 1) != (target % 5)))
                {
                    return 3;
                }
                else
                {
                    if ((570 & 31) >= span)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)607 >= (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long TotalFarmMetrics(long[] samples)
        {
            long carry = 467;
            foreach (long entry in samples)
            {
                if (((long)samples.Length ^ 49) != (carry + carry))
                {
                    carry = (carry - entry) % 101;
                }
                if ((entry + carry) == (99 % 8))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
